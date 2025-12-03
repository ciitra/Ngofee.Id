using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Iinterfaces
{
    public interface IAuth
    {
        UserModel Login(UserModel user);
        bool Register(UserModel user);
    }
}
