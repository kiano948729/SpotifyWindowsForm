using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWindowsForm.Services
{
    public class authenticationService
    {
        public string loggedInUser {  get; set; }
        public bool AuthenticationService(string Username, string Password) {
            string user1 = "testgebruiker1";
            string user1Pass = "login1";

            string user2 = "tester2";
            string user2Pass = "login2";
            

            if (Username == user1 && Password == user1Pass || Username == user2 && user2Pass == Password)
            {   
                loggedInUser = Username;
                return true;
            }
            else
            {
                return false;
                
            }

        }
    }
}

