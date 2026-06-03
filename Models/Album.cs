using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWindowsForm.Models
{
    public class Album
    {
        public string Name { get; set; }
        public int TotalSongs { get; set; }


        public Album(string name)
        {
            Name= name;
        }
        public void Getinfo()
        {
            console.WriteLine(Name)
        }
        public void Updateinfo() 
        { 
        
        }
        public void Deleteinfo()
        {

        }
        public void Addsong()
        {

        }
        public void Removesong()
        {

        }
    }
}
