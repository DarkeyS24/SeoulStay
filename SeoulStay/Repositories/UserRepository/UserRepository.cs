using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeoulStay.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {

        private HttpClient httpClient;

        public UserRepository()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7047/api/Users/");
        }

        public string PostUser(string url, string json)
        {
            var response = httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            if (response.Result.IsSuccessStatusCode)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
    