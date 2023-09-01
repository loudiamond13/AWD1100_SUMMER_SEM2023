using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocSecNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string ZipCode { get; set; }


        public Employee() { }

        public override string ToString()
        {
            return "First Name: "           + FirstName +       "\n" +
                    "Last Name: "           + LastName+        "\n" +
                    "Social Security #: "   + SocSecNumber+    "\n" +
                    "Address: " +Address+ "\n" +
                    "City: " +City+ "\n" +
                    "State: " +State+"\n" +
                    "Zip Code: "+ZipCode+ "\n";
        }

    }
}
