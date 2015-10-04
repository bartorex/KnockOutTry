using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Domain.Models;

namespace KnockOutWebAPI.Controllers
{
    public class UserController : ApiController
    {
        private List<User> userModelList; 
        
        public UserController()
        {
            userModelList = new List<User>
            {
                new User() {FirstName = "Some Name", Id = 1, LastName = "Some LastName"},
                new User() {FirstName = "Some Name2", Id = 2, LastName = "Some LastName2"}
            };
        }

        public List<User> GetAllUsers()
        {
            return userModelList;
        }

        public User GetUser(int id)
        {
            return userModelList.FirstOrDefault(x => x.Id == id);
        }

        public void AddUser(User userModel)
        {
            if (ModelState.IsValid)
            {
                userModelList.Add(userModel);
            }
        }
    }
}
