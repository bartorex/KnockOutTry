define(['knockout', 'text!./user.html'], function(ko, templateMarkup) {

  function User(params) {
    this.message = ko.observable('Hello from the user component!');
  }

  // This runs when the component is torn down. Put here any logic necessary to clean up,
  // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
  User.prototype.dispose = function() { };
  
  return { viewModel: User, template: templateMarkup };

});
