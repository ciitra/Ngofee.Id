using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Helpers
{
    public static class AppSession
    {
        public static UserModel CurrentUser { get; private set; }
        public static bool IsAuthenticated => CurrentUser != null;

        public static void SetUser(UserModel user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}

