ko.bindingHandlers["dotvvm-contrib-MaskMoney"] = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        $(element).maskMoney();

        ko.utils.registerEventHandler(element, 'focusout', function () {
            var observable = valueAccessor();
            observable($(element).val());
        });
        // remove the handler when the control is removed from the page
        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            $(element).maskMoney('destroy');
        });

    }
};
