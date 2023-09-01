using SongLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

using static System.Console;


namespace SongSearchConsole 
{
    internal class Program { 


        //global const var
        const string NOINPUT = "NO INPUT TO SEARCH. ";
        const string TITLENOTFOUND = "SONG TITLE NOT FOUND";
        const string ARTISTNOTFOUND = "NO SONG ARTIST FOUND";
        const string SONGGENRENOTFOUND = "NO SONG GENRE FOUND";


        static List<Songs> Songs = SongList.LoadData();




        static void Main(string[] args)
        {
            //program continue or not 
            bool runProgram = true;
            //Menu option
            int choosenOpt;


            while (runProgram)  
            {
                choosenOpt = ShowMenu();
                performSearch(choosenOpt);
                runProgram = runAgain();
            
            }



        }


        static int ShowMenu()
        {
            //value returned
            bool result;
            //option entered 
            string optionChoosenStr = "";
            // int entered option
            int optionChoosenInt = 0;

            Clear();

            // menu option string
            string menu = $"Please Choose One Menu Options \n" +
                          $"Enter 1 to show all songs by title in ascending order.\n" +
                          $"Enter 2 to show all songs by artist in ascending order.\n" +
                          $"Enter 3 to show all songs by genre in ascending order.\n" +
                          $"Enter 4 to show all songs by entering the song title.\n" +
                          $"Enter 5 to show all songs by entering the song artist.\n" +
                          $"Enter 6 to show all songs by entering the song genre.\n" +
                          $"Enter 7 to Exit The Program\n" +
                          $"ENTER KEY: ";

            // show menu to the user
            Write(menu);
            optionChoosenStr = ReadLine();
            
            // validate if users input is valid (int 1-7)
            result = Int32.TryParse(optionChoosenStr,out optionChoosenInt);


            // if the users input is  non-numeric, show message 
            if (!result)
            {
                Write($"Please Enter A NUMBER!\n Hit Ant Key To Continue:  ");
                ReadLine(); 
                ShowMenu();

                //else if users input is >7 or <1, show error message (out of range )
            } else if (optionChoosenInt > 7 || optionChoosenInt < 1) 
            {
                Write("YOU MUST INPUT BETWEEN 1-7! \n Hit Ant Key To Continue:   ");
                ReadLine();
                ShowMenu();
            }

            return optionChoosenInt;
        }


        static void performSearch(int optionENTERED)
        { 
            switch (optionENTERED) 
            {
                // if opt 1 is choosen, show song title by ascending order  
                case 1:
                    ShowSongsByTitleASC();
                    break;

                // if opt 2 is choosen, show song artist by ascending order 
                case 2:
                    ShowSongsByArtistASC();
                    break;

                // if opt 3 is choosen, show song genre by ascending order 
                case 3:
                    ShowSongsByGenreASC();
                    break;

                // if opt 4 is choosen, show song title search 
                case 4:
                    SearchInputTitle();
                    break;

                // if opt 4 is choosen, show song artist search 
                case 5:
                    SearchInputArtist();
                         break;

                // if opt 4 is choosen, show song genre search 
                case 6:
                    SearchInputGenre();
                    break;

                case 7:
                    exitProgram();
                    break;

                default:
                    break;
            }
        
        }

        static void ShowSongsByTitleASC() 
        {
            Clear();

            // perform linq search
            var SongTitleASC = from s in Songs orderby s.SongTitle ascending select s;

            WriteLine("\nSong List in Ascending order by Song Title: \n");

            // write all linq search results from list
            foreach (var songs in SongTitleASC)
            { 
                WriteLine(songs);
            }

            ReadLine();
        }

        static void ShowSongsByArtistASC()
        {
            Clear();

            // perform linq search
            var SongArtistASC = from s in Songs orderby s.SongArtist ascending select s;

            WriteLine("\nSong List in Ascending order by Song Artist: \n");

            // write all linq search results from list
            foreach (var songs in SongArtistASC)
            {
                WriteLine(songs);
            }

            ReadLine();
        }

        static void ShowSongsByGenreASC()
        {
            Clear();

            // perform linq search
            var SongGenreASC = from s in Songs orderby s.SongGenre ascending select s;

            WriteLine("\nSong List in Ascending order by Song Genre: \n");

            // write all linq search results from list
            foreach (var songs in SongGenreASC)
            {
                WriteLine(songs);
            }

            ReadLine();
        }


        static void SearchInputTitle() 
        {
            Clear();

           

            Write("\nEnter A Song Title To Search(Full or Partial): ");
            string title = ReadLine();  // gets the users input to search


            // check if there is something inputted 
            if (title.Trim() == string.Empty) 
            {
                WriteLine(NOINPUT);
                ReadLine();
            
            }
            //else if there is song title input to search
            else 
            {
                // perform linq search and return the song title that is searched
                var searchSongTitle = from s in Songs orderby s.SongTitle ascending
                                      where s.SongTitle.ToUpper().Contains(title.ToUpper())
                                      select s;


                WriteLine("\nSong Titles Matching the Inputted Title To Search: \n ");
                foreach(var songs in searchSongTitle) 
                {
                   

                    WriteLine(songs);
                   
                }

                ReadLine();
            }




        }


        static void SearchInputArtist()
        {
            Clear();



            Write("\nEnter A Song Title To Search(Full or Partial): ");
            string artist = ReadLine();  // gets the users input to search


            // check if there is something inputted 
            if (artist.Trim() == string.Empty)
            {
                WriteLine(NOINPUT);
                ReadLine();

            }
            //else if there is song title input to search
            else
            {
                // perform linq search and return the song artist that is searched
                var searchSongArtist = from s in Songs
                                      orderby s.SongArtist ascending
                                      where s.SongArtist.ToUpper().Contains(artist.ToUpper())
                                      select s;


                WriteLine("\nSong Titles Matching the Inputted Title To Search: \n ");
                foreach (var songs in searchSongArtist)
                {
                    // show all result

                    WriteLine(songs);

                }

                ReadLine();
            }




        }


        static void SearchInputGenre()
        {
            Clear();



            Write("\nEnter A Song Title To Search(Full or Partial): ");
            string genre = ReadLine();  // gets the users input to search


            // check if there is something inputted 
            if (genre.Trim() == string.Empty)
            {
                WriteLine(NOINPUT);
                ReadLine();

            }
            //else if there is song title input to search
            else
            {
                // perform linq search and return the song genre that is searched
                var searchSongGenre = from s in Songs
                                       orderby s.SongGenre ascending
                                       where s.SongGenre.ToUpper().Contains(genre.ToUpper())
                                       select s;


                WriteLine("\nSong Titles Matching the Inputted Title To Search: \n ");
                foreach (var songs in searchSongGenre)
                {
                    // show all result

                    WriteLine(songs);

                }

                ReadLine();
            }




        }


        static bool runAgain()
        {
            bool ret = true;

            WriteLine("EXIT PROGRAM? (Y/N): ");
            string exitORno = ReadLine();

            if (exitORno.ToUpper() == "Y")
            {
                Environment.Exit(0);
                ret = false;
            }
            else { ret = true; }
        

            return ret;
        }

        static void exitProgram()
        {
            Clear();
            WriteLine("Program Exiting! BYE!");
            ReadLine();
            Environment.Exit(0);
        
        }

    }
}