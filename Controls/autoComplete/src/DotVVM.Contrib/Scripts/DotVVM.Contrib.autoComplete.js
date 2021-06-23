ko.bindingHandlers["dotvvm-contrib-autoComplete"] = {
    init: function (element, valueAccessor) {
        $(element).autocomplete({
            minChars: '2',
            params: {
                appkey: 1337
            },
            serviceUrl: '/AppServices/AutocompliteAPI.asmx/GetCityForAutocompliteJSON',
            onSelect: function (suggestion) {
                var accessor = valueAccessor();
                accessor.autoID(suggestion.data);
                accessor.autoDeliveryTerm(suggestion.deliveryterms);
                accessor.autoDeliveryDate(suggestion.deliverydate);
                accessor.autoValue(suggestion.value);
               

            },
            delimiter: ";"
        });
        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            $(element).autocomplete('destroy');
        });
    }
};
