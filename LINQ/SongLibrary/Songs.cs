using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongLibrary
{
    public class Songs
    {

        public string SongTitle { get; set; }
        public string SongArtist { get; set;}

        public string SongGenre { get; set;}

        public  Songs()
        { }

        public override string ToString()
        {
            return "Song Title: " + SongTitle + "\n" +
                    "Song Artist: " + SongArtist + "\n"+
                    "Song Genre: " + SongGenre + "\n";
        }
    }
}
