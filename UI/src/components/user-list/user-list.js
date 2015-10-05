define(['knockout', 'text!./user-list.html'], function (ko, templateMarkup) {

    //function User(data) {
    //    this.Id = ko.observable(data.Id);
    //    this.FirstName = ko.observable(data.FirstName);
    //    this.LastName = ko.observable(data.LastName);
    //    this.Gender = ko.observable(data.Gender);
    //}

    function User() {
        this.Id = ko.observable();
        this.FirstName = ko.observable();
        this.LastName = ko.observable();
        this.Gender = ko.observable();
    }

    function Userlist(params) {
        //this.message = ko.observable('Hello from the userList component!');
        var self = this;
        self.users = ko.observableArray();
        self.chosenUserData = ko.observable();
        self.newUser = ko.observable(null);
        self.updatedUser = ko.observable(null);

        $.getJSON("http://localhost:6045/api/user", function (data) {
            //var mappedUsers = $.map(data, function (item) { return new User(item) });
            self.users(data);
        });

        self.goToUserData = function (user) {
            if (self.chosenUserData() != user) {
                self.chosenUserData(user);
            } else {
                self.chosenUserData(null);
            }         
        }

        self.removeUser = function (user) {
            if (user === self.chosenUserData()) {
                self.chosenUserData(null);
            }

            $.ajax({
                url: 'http://localhost:6045/api/user/DeleteUser',
                type: 'DELETE',
                data: user              
            });
            self.users.remove(user);
        }

        self.addUser = function() {
            self.newUser(new User());
        }

        self.cancelAddUser = function() {
            self.newUser(null);
        }

        self.cancelUpdateUser = function() {
            self.updatedUser(null);
        }

        self.hideUserData = function() {
            self.chosenUserData(null);
        }

        self.goToUpdateUser = function() {
            var currentUser = self.chosenUserData();
            self.chosenUserData(null);
            self.updatedUser(currentUser);
        }

        self.saveUser = function () {
            var newUser = self.newUser();
            $.post("http://localhost:6045/api/user", newUser).done(function(id) {
                newUser.Id(id);
            });
            self.users.push(newUser);
            self.newUser(null);
        }

        self.updateUser = function () {
            var updatedUser = self.updatedUser();
            //$.put("http://localhost:6045/api/user", updatedUser).done(function () {
               
            //});
            $.ajax({
                url: 'http://localhost:6045/api/user/',
                type: 'put',
                data: updatedUser
            });
            self.updatedUser(null);
        }
    }

    // This runs when the component is torn down. Put here any logic necessary to clean up,
    // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
    Userlist.prototype.dispose = function () { };

    return { viewModel: Userlist, template: templateMarkup };

});
