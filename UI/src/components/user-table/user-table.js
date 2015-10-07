define(['knockout', 'text!./user-table.html'], function (ko, templateMarkup) {
    function User() {
        this.Id = ko.observable();
        this.FirstName = ko.observable();
        this.LastName = ko.observable();
        this.Gender = ko.observable();
    }

    function UserTable(params) {
        var self = this;
        self.users = params.Value;
        //this.message = ko.observable('Hello from the user-table component!');
    }

    // This runs when the component is torn down. Put here any logic necessary to clean up,
    // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
    UserTable.prototype.dispose = function () { };

    return { viewModel: UserTable, template: templateMarkup };

});
