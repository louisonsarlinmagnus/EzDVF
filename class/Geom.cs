using System.Collections.Generic;
namespace   EzDVF_IHM
{
    public class Geom
    {
        public Geom()
        {
            type = "pouet";
        }

        public string type {get; set;}
        public List<float> coordinates = new List<float>() {0f ,0f};
    }
}