using Microsoft.VisualBasic;
using System.Data;
using System.Globalization;

namespace Reservations
{
    public partial class frmReservations : Form
    {


        // global for todays date
        DateTime todaysDate = DateAndTime.Now;

        // declaring const for minimum date and maximum date



        public frmReservations()
        {
            InitializeComponent();





            // initializing textbox
            //set day a day advance
            txtArrivalDate.Text = todaysDate.ToString("M/dd/yyyy");
            txtDepartureDate.Text = todaysDate.ToString("M/dd/yyyy");
        }





        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            try {


                bool isValid = IsValidData();

                int     totPrice    = 0;
                int     numdays     = 0;
                decimal avgPrice    = 0m;



                if (isValid)
                {
                    //taking the input dates
                    DateTime arrDate = DateTime.Parse(txtArrivalDate.Text);
                    DateTime depDate = DateTime.Parse(txtDepartureDate.Text);

                    depDate = depDate.AddDays(-1);// minus 1 for departure day, this night wont be counted 

                    //looping the dates
                    for (var day = arrDate.Date; day.Date <= depDate.Date; day = day.AddDays(1)  ) 
                    {


                        // if days falls in saturday or friday, rate 150, else 120
                        if (day.ToString("ddd") == "Fri" ||
                            day.ToString("ddd") == "Sat")
                        {
                            //count the days 
                            totPrice += 150;
                            numdays++;
                        }
                        else 
                        {
                            //count the days 
                            numdays++;  
                            totPrice += 120;
                        }


                    }

                    //get the avgprice
                    avgPrice = totPrice / numdays;

                    //display results

                    txtAvgPrice.Text = avgPrice.ToString("c");
                    txtNights.Text = numdays.ToString();
                    txtTotalPrice.Text = totPrice.ToString("c");
                }
            }
           catch (Exception exe)
            {

                MessageBox.Show(exe.Message, "Error");
            }


        }



        

        public bool IsValidData()
        {


            bool success = true;
            string errorMessage = "";

            // Validate the Arrival date text box
            errorMessage += IsPresent(txtArrivalDate.Text, "Arrival date");

            // Validate the Departure date text box
            errorMessage += IsPresent(txtDepartureDate.Text, "Departure date");


            // validate if the input date for arrival and departure dates are valids 
            errorMessage += IsDateTime(txtArrivalDate.Text, "Arrival Date");
            errorMessage += IsDateTime(txtDepartureDate.Text, "Departure Date");


            //validate input date if valid
            // arrival date cannot be before today and departure date cannot be before the arrival 
            errorMessage += IsWithinDateRange(txtArrivalDate.Text, "Arrival Date", 
                            todaysDate.AddDays(-1), todaysDate.AddYears(1));

            errorMessage += IsLaterDate(txtArrivalDate.Text, "Arrival Date", 
                            txtDepartureDate.Text, "Departure Date");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        public string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }
            return msg;
        }

        public string IsDateTime(string value, string name)
        {
            string msg = "";

            //
            bool isvalidDate = DateTime.TryParseExact(value,
                                "M/dd/yyyy",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out DateTime _);

            // validate date if valid

            if (!isvalidDate)
            {

                msg = name + " is Invalid Date! (M/DD/YYYY).\n";
            }
            return msg;
        }

        public string IsWithinDateRange(string value, string name,
            DateTime min, DateTime max)
        {
            string msg = "";


            
            //convert input into dateTIme
            DateTime inputDate = DateTime.Parse(value);


            // validate input 
            if (inputDate < min) // if input date is already past, show error
            {
                msg = name + " Can't Be Before Today's Date.";
            
            }
            else if (inputDate > max)  // if input date is more than a year, show error
            {
                msg = name + " Can't Be a Year Advance From Today's Date";
            }

          
             



            return msg;
        }

        public string IsLaterDate(string earlyValue, string earlyName,
            string laterValue, string laterName)
        {
            

            string msg = "";

            //converting input dates strings to DateTime 
            DateTime arrivalDate    = DateTime.Parse(earlyValue);
            DateTime departureDate  = DateTime.Parse(laterValue);

            //  int asd = arrivalDate.CompareTo(departureDate);

            //    txtNights.Text = asd.ToString();

            // if departure is before arrival, send error
            if (departureDate < arrivalDate)
            {
                msg = laterName + " Must Be Atleast a Day Advance From The " + earlyName + ".";
            
            }

            return msg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}