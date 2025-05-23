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
            httpClient.BaseAddress = new Uri("http://localhost:7047/api/Users/");
        }

        public async Task<string> PostUser(string url, string json)
        {
            var str = await httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
            return str.Content.ReadAsStringAsync().Result;
        }
    }
}
