using SpotifyWindowsForm.Data;
using SpotifyWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWindowsForm.Services
{
    public static class LoginService
    {
        public static User? CurrentUser { get; private set; }

        public static bool Login(string username, string password)
        {
            User? user = UserStore.Users.FirstOrDefault(
                u => u.Username == username &&
                     u.Password == password);

            if (user != null)
            {
                CurrentUser = user;
                return true;
            }

            return false;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
