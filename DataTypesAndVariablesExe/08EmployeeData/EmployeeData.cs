using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            long personalID = long.Parse(Console.ReadLine());
            long employeeID = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + secondName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + personalID);
            Console.WriteLine("Unique Employee number: " + employeeID);

        }
    }
}
