using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWindowsForm.Models
{
    public class FriendRequest
    {
        public User Sender { get; set; }
        public User Receiver { get; set; }


        public FriendRequest(User sender, User receiver)
        {
            Sender = sender;
            Receiver = receiver;
        }
    }
}
