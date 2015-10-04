define(['knockout', 'text!./programme-grid.html'], function(ko, templateMarkup) {

  function ProgrammeGrid(params) {
      this.FirstName = ko.observable("Tom");
      this.LastName = ko.observable("Labak");
  }

  return { viewModel: ProgrammeGrid, template: templateMarkup };

});
