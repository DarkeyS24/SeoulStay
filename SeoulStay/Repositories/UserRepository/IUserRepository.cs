using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeoulStay.Repositories.UserRepository
{
    public interface IUserRepository
    {
        HttpResponseMessage PostUser(string url, string json);
    }
}
