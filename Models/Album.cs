using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWindowsForm.Models
{
    public class Album
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}
