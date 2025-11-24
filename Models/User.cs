using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NoTelepon { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        admin, pembeli
    }
}
