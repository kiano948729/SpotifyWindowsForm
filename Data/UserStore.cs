using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyWindowsForm.Models;
using SpotifyWindowsForm.Services;

namespace SpotifyWindowsForm.Data
{
    internal class UserStore
    {
        public static List<User> Users = new List<User>
    {
        new User("testgebruiker1"),
        new User("tester2")
    };
    }
}
