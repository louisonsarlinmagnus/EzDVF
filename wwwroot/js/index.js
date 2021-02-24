$('#query-form').submit(function() {
    if ($.trim($("#communal-code").val()) === "" && $.trim($("#plan-number").val()) === "" && $.trim($("#section").val()) === "" && $.trim($("#zipcode").val()) === "") {
        alert('Veuillez remplir au moins un des champs!');
        return false;
    }
});