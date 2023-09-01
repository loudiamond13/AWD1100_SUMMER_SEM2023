using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongLibrary
{
    public class SongList
    {

        public static List<Songs> LoadData()
        {
            var songList = new List<Songs>();

            songList.Add(new Songs { SongTitle = "Wonderful Tonight", SongArtist = "Eric Clapton", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "I Told You So", SongArtist = "Randy Travis", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Keep Your Hands To Yourself", SongArtist = "Georgia Satellites", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "I'll Do It For You", SongArtist = "Bryan Adams", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Tears In Heaven", SongArtist = "Eric Clapton", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Comfortably Numb", SongArtist = "Pink Floyd", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "While My Guitar Gently Weeps", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Horse With No Name", SongArtist = "America", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "I Want To Hold Your Hand", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Baby I'm A Want Your", SongArtist = "Bread", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "A Day In The Life", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Don't Close Your Eyes", SongArtist = "Keith Whitley", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Saturday In The Park", SongArtist = "Chicago", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Kiss A Girl", SongArtist = "Keith Urban", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "In My Life", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Come Together", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Come Sail Away", SongArtist = "Styx", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Smoke On The Water", SongArtist = "Deep Purple", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Slow Ride", SongArtist = "Foghat", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Single Ladies", SongArtist = "Beyonce", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Umbrella", SongArtist = "Rihanna", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Shake It Off", SongArtist = "Taylor Swift", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Toxic", SongArtist = "Brittany Spears", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Rolling In The Deep", SongArtist = "Adele", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "The Dance", SongArtist = "Garth Brooks", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Tush", SongArtist = "ZZ Top", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Tom Sawyer", SongArtist = "Rush", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Fancy", SongArtist = "Reba McEntire", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Firework", SongArtist = "Katy Perry", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "I Love Rock 'N' Roll", SongArtist = "Joan Jett", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Blinding Light", SongArtist = "The Weekend", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Dancing On My Own", SongArtist = "Robin", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Hey Ya!", SongArtist = "Outkast", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Hips Don't Lie", SongArtist = "Shakira", SongGenre = "Pop" });
            songList.Add(new Songs { SongTitle = "Strawberry Fields Forever", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Yesterday", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "Here Comes The Sun", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "I'll Follow The Sun", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "He Stopped Loving Her Today", SongArtist = "George Jones", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Stand By Your Man", SongArtist = "Tammy Wynette", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Pride And Joy", SongArtist = "Stevie Ray Vaughn", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Tequila Sunrise", SongArtist = "The Eagles", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "No Sugar Tonight", SongArtist = "Guess Who", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Barracuda", SongArtist = "Heart", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Take Me Home, Country Roads", SongArtist = "John Denver", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Before He Cheats", SongArtist = "Carrie Underwood", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "How Deep Is Your Love", SongArtist = "Bee Gees", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Yellow Submarine", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "All Out Of Love", SongArtist = "Air Supply", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "I Want To Know What Love Is", SongArtist = "Foreigner", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "You're Beautiful", SongArtist = "James Blunt", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Don't Let Me Down", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "I'm Yours", SongArtist = "Jason Mraz", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Hey Jude", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "All By MySelf", SongArtist = "Eric Carmen", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Desparado", SongArtist = "The Eagles", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Let It Be", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "The Boys Are Back In Town", SongArtist = "Thin Lizzy", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Take It To The Limit", SongArtist = "The Eagles", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Unchained Melody", SongArtist = "Righteous Brothers", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Tightrope", SongArtist = "Stevie Ray Vaughn", SongGenre = "Rock" });
            songList.Add(new Songs { SongTitle = "Purple Haze", SongArtist = "Jimi Hendrix", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "The Gambler", SongArtist = "Kenny Rogers", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Friends In Low Places", SongArtist = "Garth Brooks", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Whole Lotta Love", SongArtist = "Led Zepplin", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Lady", SongArtist = "Styx", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Something", SongArtist = "Beatles", SongGenre = "Classic" });
            songList.Add(new Songs { SongTitle = "A Boy Named Sue", SongArtist = "Johnny Cash", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "I Walk The Line", SongArtist = "Johnny Cash", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Locomotive Breath", SongArtist = "Jethro Tull", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "Amarillo By Morning", SongArtist = "George Strait", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Kiss An Angel Good Morning", SongArtist = "Charley Pride", SongGenre = "Country" });
            songList.Add(new Songs { SongTitle = "Me & Bobby McGee", SongArtist = "Janis Joplin", SongGenre = "Rock and Roll" });
            songList.Add(new Songs { SongTitle = "More Than Words", SongArtist = "Extreme", SongGenre = "Soft Rock" });
            songList.Add(new Songs { SongTitle = "Let Her Cry", SongArtist = "Hootie & Blowfish", SongGenre = "Soft Rock" });


            return songList;
        }
    }
}
