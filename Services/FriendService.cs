using SpotifyWindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWindowsForm.Services
{
    public class FriendService
    {
        private List<FriendRequest> requests = new();

        public void SendRequest(User sender, User receiver)
        {
            requests.Add(new FriendRequest(sender, receiver));
        }

        public List<FriendRequest> GetRequestsForUser(User user)
        {
            return requests
                .Where(r => r.Receiver == user)
                .ToList();
        }

        public void AcceptRequest(FriendRequest request)
        {
            request.Sender.Friends.Add(request.Receiver);
            request.Receiver.Friends.Add(request.Sender);

            requests.Remove(request);
        }

        public void RejectRequest(FriendRequest request)
        {
            requests.Remove(request);
        }
    }

}

