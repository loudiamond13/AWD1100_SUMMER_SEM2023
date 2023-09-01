using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmployeeList
    {

        public static List<Employee> LoadData()
        {
            var empList = new List<Employee>();


            empList.Add(new Employee { FirstName = "John", LastName = "Doe", SocSecNumber = "111-22-3333", Address = "123 Main St.", City = "O'Fallon", State = "MO", ZipCode = "63366" });
            empList.Add(new Employee { FirstName = "Mary", LastName = "Smith", SocSecNumber = "111-22-3334", Address = "234 Elm Way", City = "O'Fallon", State = "MO", ZipCode = "63366" });
            empList.Add(new Employee { FirstName = "Ken", LastName = "Cramer", SocSecNumber = "222-33-4567", Address = "1914 Oak St.", City = "O'Fallon", State = "MO", ZipCode = "63366" });
            empList.Add(new Employee { FirstName = "Mike", LastName = "Adams", SocSecNumber = "192-32-2222", Address = "5619 Bell Way", City = "St. Peters", State = "MO", ZipCode = "63303" });
            empList.Add(new Employee { FirstName = "Karen", LastName = "Crane", SocSecNumber = "333-44-5678", Address = "19 Park Place", City = "St. Peters", State = "MO", ZipCode = "63303" });
            empList.Add(new Employee { FirstName = "Bryan", LastName = "Kent", SocSecNumber = "333=55=7890", Address = "2312 Ninth St.", City = "St. Peters", State = "MO", ZipCode = "63303" });
            empList.Add(new Employee { FirstName = "Sven", LastName = "James", SocSecNumber = "888-77-6666", Address = "1800 Tenth Way", City = "St. Peters", State = "MO", ZipCode = "63303" });
            empList.Add(new Employee { FirstName = "Kent", LastName = "White", SocSecNumber = "777-66-5555", Address = "57 Board Pl.", City = "St. Peters", State = "MO", ZipCode = "63303" });
            empList.Add(new Employee { FirstName = "Bill", LastName = "Green", SocSecNumber = "666-55-4444", Address = "22 Tree Way", City = "St. Peters", State = "MO", ZipCode = "63303" });
            empList.Add(new Employee { FirstName = "Bob", LastName = "Gold", SocSecNumber = "555-44-3333", Address = "4444 4th St.", City = "St. Charles", State = "MO", ZipCode = "63301" });
            empList.Add(new Employee { FirstName = "Fred", LastName = "Black", SocSecNumber = "444-33-2222", Address = "98 Forest Way", City = "St. Charles", State = "MO", ZipCode = "63301" });
            empList.Add(new Employee { FirstName = "Jean", LastName = "Brown", SocSecNumber = "333-22-1111", Address = "5432 Green Dr.", City = "St. Charles", State = "MO", ZipCode = "63301" });
            empList.Add(new Employee { FirstName = "Jane", LastName = "Smith", SocSecNumber = "222-11-0000", Address = "51 Black Dr.", City = "St. Charles", State = "MO", ZipCode = "63301" });
            empList.Add(new Employee { FirstName = "Joan", LastName = "Stein", SocSecNumber = "111-00-9999", Address = "99 Kent Pl.", City = "Wentzville", State = "MO", ZipCode = "63385" });
            empList.Add(new Employee { FirstName = "Ben", LastName = "Jones", SocSecNumber = "222-33-4444", Address = "5050 One Way", City = "Wentzville", State = "MO", ZipCode = "63385" });
            empList.Add(new Employee { FirstName = "Mark", LastName = "Freed", SocSecNumber = "333-44-5555", Address = "1912 Green Dr.", City = "Wentzville", State = "MO", ZipCode = "63385" });
            empList.Add(new Employee { FirstName = "Dick", LastName = "Jones", SocSecNumber = "444-55-6666", Address = "123 Forest Way", City = "Wentzville", State = "MO", ZipCode = "63385" });
            empList.Add(new Employee { FirstName = "Mike", LastName = "James", SocSecNumber = "777-88-9999", Address = "222 3rd St.", City = "Wentzville", State = "MO", ZipCode = "63385" });
            empList.Add(new Employee { FirstName = "Bill", LastName = "White", SocSecNumber = "888-99-0000", Address = "1910 Felt Way", City = "Wentzville", State = "MO", ZipCode = "63385" });
            empList.Add(new Employee { FirstName = "Fred", LastName = "Bryant", SocSecNumber = "555-66-7777", Address = "145 Forest Way", City = "Wentzville", State = "MO", ZipCode = "63385" });


            return empList;
        }
    }
}
