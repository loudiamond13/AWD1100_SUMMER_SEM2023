using System;

namespace HOT1_TShirtsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal SHIRTprice     = 14.99m;   // price per Tshirt 
            const decimal TAXpercentage = 0.08m;     //tax percentage 8%




            //asks the users Name
            Console.Write("Enter your name: ");
            // DECLARING VARIABLES
            string name = Console.ReadLine();

            //asks the users street Address
            Console.Write("Street Address: ");
            string street = Console.ReadLine();

            //asks the users city
            Console.Write("City: ");
            string city = Console.ReadLine();

            //asks the users state
            Console.Write("State: ");
            string state = Console.ReadLine();

            //asks the users zip
            Console.Write("Zip: ");
            int zip = Convert.ToInt32(Console.ReadLine());

            // asks the user how many orders
            Console.Write("How many T-Shirts do you want to order? ");
            int orderPCS = Convert.ToInt32(Console.ReadLine());


            // calculate the total
            decimal total = orderPCS * SHIRTprice;
            decimal tax = total * TAXpercentage;
            decimal due = total + tax;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Printing the receipt
            Console.Write("Receipt For: \n" +
                name +"\n"+ 
                street +"\n"+
                city +", "+ state +" "+ zip +"\n");
            
            
            Console.WriteLine();
            Console.Write(orderPCS + " T-Shirts ordered @ " + SHIRTprice.ToString("c") + " each" );
            Console.WriteLine();
            Console.WriteLine();

            //prints the total and tax
            Console.Write("Total: \t\t" + total.ToString("c") + "\n");
            Console.WriteLine("Tax: \t\t" + tax.ToString("c"));
            Console.WriteLine("- - - - - - - - - - - - - -");

            //prints the due amount
            Console.WriteLine("Due: \t\t" + due.ToString("c"));
            Console.Write("Press Any Key To Continue  .  .  .");






            Console.ReadKey();

        }
    }
}
