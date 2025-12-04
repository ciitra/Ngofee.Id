using Ngofee.Id.Iinterfaces;
using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Controllers
{
    public class MockAuthController : IAuth
    {
        public UserModel Login(UserModel user)
        {
            return new UserModel
            {
                UserId = 999,
                Username = "MockUser",
                Email = "mock@example.com",
                NoTelepon = "0000000000",
                Role = UserRole.pembeli
            };
        }

        public bool Register(UserModel user)
        {
            return true;
        }
    }
}
