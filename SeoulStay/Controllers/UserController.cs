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
            return userRepository.PostUser(url, ConvertToJson(user)).Result;
        }

        private static string ConvertToJson(User user)
        {
            string str = new string
            (
             "{" +
             "\"username\": \"" + user.Username + "\"," +
             "\"password\": \"" + user.Password + "\"" +
             "}"
            );
            return str;
        }
    }
}
