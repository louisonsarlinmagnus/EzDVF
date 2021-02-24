using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Logging;
using EzDVF;

namespace EzDVF.Pages
{
    //TODO: Affichage du nombre de résultats trouvés sur Index
    //TODO: Manuel d'utilisation à modifier
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public InputCriteria input {get; set;}

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet() {}

        public async Task<IActionResult> OnPostSubmit() {
            if (!ModelState.IsValid) return Page();
            string request = TriCriteres();
            string fileName = Path.Combine("resultats-" + "-" + request + "-" + DateTime.Now.ToString("yyyyMMdd") + ".csv"); //Format de fileName: ./resultats-[REQUETE]-[DATE].csv
            Results results = Convert.fromRequestToObjects(request, _logger);
            ViewData["ResultNumber"] = results.nb_resultats;
            if ((results.nb_resultats == 0)||(results.nb_resultats == null)) return Page();
            Convert.fromResultsToCSV(results, fileName);
            return await Downloader(fileName);
        }

        private async Task<IActionResult> Downloader(string fileName) {
            MemoryStream memory = new MemoryStream();  
            try {
                using (FileStream stream = new FileStream(fileName, FileMode.Open))  await stream.CopyToAsync(memory);
                System.IO.File.Delete(fileName);
                memory.Position = 0;  
            } catch {
                _logger.LogError($"File {fileName} not found");
            }
            return File(memory, "text/csv", fileName);
        }

        private string TriCriteres() {
            string request = "";
            if (input.communalCode != null) request += "code_commune=" + input.communalCode.ToString() + "&";
            if (input.section != null) request += "section=" + input.section.ToString() + "&";
            if (input.planNumber != null) request += "numero_plan=" + input.planNumber.ToString() + "&";
            if (input.zipCode != null) request += "code_postal=" + input.zipCode.ToString() + "&";
            if (request.Last() == '&') request.Remove(request.Length - 1);
            return request;
        }

    }

    public class InputCriteria {
        [Display(Name = "Code Commune:")]
        public string communalCode {get; set;}

        [Display(Name = "Section Cadastrale:")]
        public string section {get; set;}

        [Display(Name = "Identifiant de la parcelle:")]
        public string planNumber {get; set;}

        [Display(Name = "Code Postal:")]
        public string zipCode {get; set;}

    }

}
