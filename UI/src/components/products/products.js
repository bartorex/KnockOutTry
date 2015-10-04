define(['knockout', 'text!./products.html', 'jquery'], function (ko, templateMarkup, $) {

    function Products(params) {
        var self = this;
        self.message = ko.observable("Products");
        self.Id = ko.observable();
        self.Name = ko.observable();
        self.Category = ko.observable();
        self.Price = ko.observable();

        $.getJSON("http://localhost:4940/api/products/1", function(data) {
            self.Id(data.Id);
            self.Name(data.Name);
            self.Category(data.Category);
            self.Price(data.Price);
        });
    }

    // This runs when the component is torn down. Put here any logic necessary to clean up,
    // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
    //Products.prototype.dispose = function() { };
    //ko.applyBindings(new Products());



    return { viewModel: Products, template: templateMarkup };

});
