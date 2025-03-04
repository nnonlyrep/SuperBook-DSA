using SuperBookFinalProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBookFinalProj
{
    public static class SessionManager
    {
        public static Consumer LoggedInUser { get; private set; }

        public static void SetLoggedInUser(Consumer consumer)
        {
            LoggedInUser = consumer;
        }

        public static void Logout()
        {
            LoggedInUser = null;
        }
    }
}
