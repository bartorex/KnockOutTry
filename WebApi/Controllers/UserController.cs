using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Domain.Enums;
using Domain.Models;
using EntityFrameworkConnection.UnitOfWork;
using ShopApplication.Services;
using ShopApplication.Services.Interfaces;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:14778", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        private readonly IUserService userService;

        public UserController()
        {
            userService = new UserService(new UnitOfWork());          
        }

        public async Task<User[]> GetAllUser()
        {
            var users = await userService.GetAll();
            foreach (var user in users.ToList())
            {
                if (user.Gender == Gender.Female)
                    user.Gender = Gender.Female;
            }
            return users.ToArray();
        }

        public async Task<User> GetUser(int id)
        {
            //await InitUsersDatabase();
            return await userService.GetById(id);
        }

        //public void PostTest(string i)
        //{
        //    var number = i;
        //}

        public async Task<int> PostUser(User user)
        {
            await userService.Add(user);
            return user.Id;
        }

        public async Task DeleteUser(User user)
        {
            var userFromDatabase = await userService.GetById(user);
            await userService.Delete(userFromDatabase);
        }

        //private async Task InitUsersDatabase()
        //{
        //    await userService.Add(new User()
        //    {
        //        FirstName = "Anna",
        //        LastName = "Krakowska",
        //        Gender = Gender.Female
        //    });
        //}
    }
}
