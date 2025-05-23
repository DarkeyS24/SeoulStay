using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SeoulStay.Models;
using SeoulStay.Repositories.UserRepository;

namespace SeoulStay.Controllers
{
    public static class UserController
    {
        public static string PostUser(string url, User user)
        {
            var userRepository = new UserRepository();
            return string.Concat(userRepository.PostUser(url, ConvertToJson(user)));
        }

        private static string ConvertToJson(User user)
        {
            Login login = new Login
            {
                username = user.Username,
                password = user.Password
            };
            return JsonSerializer.Serialize(login); ;
        }

        private class Login
        {
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}
