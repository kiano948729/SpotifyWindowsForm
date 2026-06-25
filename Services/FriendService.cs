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

            MessageBox.Show($"Aantal requests: {requests.Count}");
        }

        public List<FriendRequest> GetRequestsForUser(User user)
        {
            MessageBox.Show($"Aantal requests totaal: {requests.Count}");
            return requests
                .Where(r => r.Receiver.Username == user.Username)
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
        public void RemoveRequest(FriendRequest request)
        {
            requests.Remove(request);
        }
    }

}

