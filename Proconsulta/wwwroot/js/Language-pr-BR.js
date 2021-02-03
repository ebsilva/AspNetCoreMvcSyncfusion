var L10n = ej.base.L10n;
L10n.load({
    "pt": {
        "calendar": {
            "today": "Hoje"
        },
        "datepicker": {
            "today": "Hoje"
        },
        "grid": {
            "FilterButton": "Filtrar",
            "Search": "Pesquisar",
            "EnterValue": "Informe descrição",
            "ClearFilter": "Sem filtro",
            "ClearButton": "Sem filtro",
            "Equal": "Igual",
            "firstPageTooltip": "Ir para primeira página",
            "lastPageTooltip": "Ir para última página",
            "nextPageTooltip": "Próxima página",
            "previousPageTooltip": "Página anterior",
            "CustomFilterDatePlaceHolder": "Selecione uma data",
            "CustomFilterPlaceHolder": "Selecione um valor",
            "ChooseDate": "Selecione uma data",
            "StartsWith": "Inicia com",
            "EndsWith": "Temina com",
            "Contains": "Contem",
            "NotEqual": "Dirente de",
            "LessThan": "Menor que",
            "LessThanOrEqual": "Menor ou igual",
            "GreaterThan": "Maior que",
            "GreaterThanOrEqual": "Maior ou igual",
            
            "All": "Todos",

        },  
        "pager": {
            "currentPageInfo": "{0} de {1} páginas",
           
            
        }
    }
});

loadCultureFiles('pt');
function loadCultureFiles(name) {
    var files = ['ca-gregorian.json', 'numberingSystems.json', 'numbers.json', 'timeZoneNames.json', 'ca-islamic.json'];
    var loader = ej.base.loadCldr;
    var loadCulture = function (prop) {
        var val, ajax;
        if (files[prop] === 'numberingSystems.json') {
            ajax = new ej.base.Ajax(location.origin + '/cldr-data/supplemental/' + files[prop], 'GET', false);
        } else {
            ajax = new ej.base.Ajax(location.origin + '/cldr-data/main/' + name + '/' + files[prop], 'GET', false);
        }
        ajax.onSuccess = function (value) {
            val = value;
        };
        ajax.send();
        loader(JSON.parse(val));
    };
    for (var prop = 0; prop < files.length; prop++) {
        loadCulture(prop);
    }
}