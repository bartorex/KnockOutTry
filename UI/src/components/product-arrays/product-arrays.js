define(['knockout', 'text!./product-arrays.html','jquery'], function(ko, templateMarkup,$) {

  function Productarrays(params) {
      var self = this;
      self.products = ko.observableArray();
      self.value = ko.observable();
      $.getJSON("http://localhost:6045/api/product", function (data) {
          for (var i = 0; i < data.length; ++i) {
              self.products.push(data[i]);
          }
      });

      function name(parameters) {
          
      }
  }

  // This runs when the component is torn down. Put here any logic necessary to clean up,
  // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
  Productarrays.prototype.dispose = function() { };
  
  return { viewModel: Productarrays, template: templateMarkup };

});
