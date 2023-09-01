using EmployeeLibrary;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace EmployeeConsoleApp
{
    internal class Program
    {
        // global const 
        const string NOINPUT = "Nothing is inputted";

        //global var
        static List<Employee> employees = EmployeeList.LoadData();


        static void Main(string[] args)
        {
            int opt;
            bool runAgain = true;


            while (runAgain) 
            {
                opt = showMenu();
                performSearch(opt);
                runAgain = run();
            }
        
        
        }

        static int showMenu()
        {
            string optChoosenStr = "";
            int optChoosenInt = 0;
            bool result;

            Clear();

            string MenuOpts = $"Please Choose One Option\n" +
                $"Enter 1 To Show All Employees by Last Name (ascending).\n" +
                $"Enter 2 To Show All Employees by Address (ascending). \n" +
                $"Enter 3 To Show All Employees by City (ascending).\n" +
                $"Enter 4 To Show All Employees by State (ascending).\n" +
                $"Enter 5 To Show All Employees by Zip Code (ascending).\n" +
                $"Enter 6 To Show All Employees Meeting Last Name (criteria).\n" +
                $"Enter 7 To Show All Employees Meeting Address (criteria).\n" +
                $"Enter 8 To Show All Employees Meeting City (criteria).\n" +
                $"Enter 9 To Exit the Program.\n" +
                $"Please Enter 1, 2 , 3, 4, 5, 6, 7, 8, or 9.  ";

            Write(MenuOpts);
            optChoosenStr = ReadLine();

            result = Int32.TryParse(optChoosenStr, out optChoosenInt);


            // if the users input is  non-numeric, show message 
            if (!result)
            {
                Write($"Please Enter A NUMBER!\nHit Ant Key To Continue:  ");
                ReadLine();
                showMenu();

                //else if users input is >9 or <1, show error message (out of range )
            }
            else if (optChoosenInt > 9 || optChoosenInt < 1)
            {
                Write("YOU MUST INPUT BETWEEN 1-9! \nHit Ant Key To Continue:   ");
                ReadLine();
                showMenu();
            }

            ReadLine();
            return optChoosenInt;
        }


        static void performSearch(int optChoosen) 
        {
            switch (optChoosen) 
            {
                case 1:
                    ShowEmpLastNameASC();
                    break;

                case 2:
                    ShowEmpAddressASC();
                    break;
                case 3:
                    ShowEmpCityASC();
                    break;
                case 4:
                    ShowEmpStateASC();
                    break;

                case 5:
                    ShowEmpZipCodeASC();
                    break;
                 case 6:
                    ShowSearchedLastName();
                        break;

                case 7:
                    ShowSearchedAddress();
                    break; 
                case 8:
                    ShowSearchedCity();
                    break;
                case 9:
                    ExitProgram();
                    break;

                default:
                    break;
            }
        
        }

        static void ShowEmpLastNameASC() 
        {
            Clear();
            
            //perform linq seach
            var empLastNameASC = from emp in employees orderby emp.LastName ascending, emp.FirstName ascending
                                 select emp;


            WriteLine("\nEmployees By Last Name In Ascending Order:\n");

            // print all linq search results
            foreach (var emp in empLastNameASC) 
            {
                WriteLine(emp);
            }
            ReadLine();
        }


        static void ShowEmpAddressASC()
        {
            Clear();

            //perform linq seach
            var empAddressASC = from emp in employees
                                 orderby emp.Address ascending
                                 select emp;


            WriteLine("\nEmployees By Address In Ascending Order:\n");

            // print all linq search results
            foreach (var emp in empAddressASC)
            {
                WriteLine(emp);
            }
            ReadLine();
        }

        static void ShowEmpCityASC()
        {
            Clear();

            //perform linq seach
            var empCityASC = from emp in employees
                                orderby emp.City ascending
                                select emp;


            WriteLine("\nEmployees By City In Ascending Order:\n");

            // print all linq search results
            foreach (var emp in empCityASC)
            {
                WriteLine(emp);
            }
            ReadLine();
        }

        static void ShowEmpStateASC()
        {
            Clear();

            //perform linq seach
            var empStateASC = from emp in employees
                             orderby emp.State ascending
                             select emp;


            WriteLine("\nEmployees By State In Ascending Order:\n");

            // print all linq search results
            foreach (var emp in empStateASC)
            {
                WriteLine(emp);
            }
            ReadLine();
        }


        static void ShowEmpZipCodeASC()
        {
            Clear();

            //perform linq seach
            var empZipCodeASC = from emp in employees
                              orderby emp.ZipCode ascending
                              select emp;


            WriteLine("\nEmployees By Zip Code In Ascending Order:\n");

            // print all linq search results
            foreach (var emp in empZipCodeASC)
            {
                WriteLine(emp);
            }
            ReadLine();
        }

        static void ShowSearchedLastName()
        {
            Clear();

            // ask the user to input lastname to search
            Write("Enter An Employee Last Name To Search (Full or Partial Last Name): ");
            string lastNameInput = ReadLine();



            if (lastNameInput.Trim() == string.Empty)
            {
                //if there is no input to search, show message
                WriteLine(NOINPUT);
                ReadLine();

            }
            else 
            {
                // else if there is input

                // perform linq search
                var empLastNameSearched = from emp in employees orderby emp.LastName ascending
                                          where emp.LastName.ToLower().Contains(lastNameInput.ToLower())
                                          select emp;


                WriteLine("Employee Last Names Matching Inputted To Search: ");

                // print all
                foreach (var emp in empLastNameSearched)
                { 
                    WriteLine(emp);
                }
                ReadLine();
            }

        
        }


        static void ShowSearchedAddress()
        {
            Clear();

            // ask the user to input lastname to search
            Write("Enter An Employee Address To Search (Full or Partial): ");
            string addressInput = ReadLine();



            if (addressInput.Trim() == string.Empty)
            {
                //if there is no input to search, show message
                WriteLine(NOINPUT);
                ReadLine();

            }
            else
            {
                // else if there is input

                // perform linq search
                var empAddressSearched = from emp in employees
                                          orderby emp.Address ascending
                                          where emp.Address.ToLower().Contains(addressInput.ToLower())
                                          select emp;


                WriteLine("Employee Address Matching Inputted To Search: ");

                // print all
                foreach (var emp in empAddressSearched)
                {
                    WriteLine(emp);
                }
                ReadLine();
            }


        }

        static void ShowSearchedCity()
        {
            Clear();

            // ask the user to input lastname to search
            Write("Enter An Employee City Adress To Search (Full or Partial): ");
            string CityInput = ReadLine();



            if (CityInput.Trim() == string.Empty)
            {
                //if there is no input to search, show message
                WriteLine(NOINPUT);
                ReadLine();

            }
            else
            {
                // else if there is input

                // perform linq search
                var empCitySearched = from emp in employees
                                         orderby emp.City ascending
                                         where emp.City.ToLower().Contains(CityInput.ToLower())
                                         select emp;


                WriteLine("Employee City Address Matching Inputted To Search: ");

                // print all
                foreach (var emp in empCitySearched)
                {
                    WriteLine(emp);
                }
                ReadLine();
            }


        }

        static bool run()
        {
            bool ret = true;
            string again = "";
            char letter = ' ';


            Write("Run The Program Again? (Y/N)");
            again = ReadLine().ToLower();
            letter = again[0];


            if (letter != 'y')
            { 
                ret = false;
            
            }
            return ret;
        }


        static void ExitProgram() 
        {
            Clear();

            WriteLine("GOODBYEEEE!");
            ReadLine();
            Environment.Exit(0);
        }



    }

}