using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Program
    {
        static List<string> records = new List<string>();
        public bool landingPage = true;
        public static void LandingPage()
        {
            Console.WriteLine("________________Student Information________________");

            Console.WriteLine("1. Add Information");
            Console.WriteLine("2. Update Information");
            Console.WriteLine("3. Delete Information");
            Console.WriteLine("4. Display Information");

            int Nav = Convert.ToInt32(Console.ReadLine());

            switch (Nav)
            {
                case 1: Console.WriteLine("Add Information" + "\n---------------------");
                    Program.AddInformation();
                    break;

                case 2: Console.WriteLine("Update Information" + "\n---------------------");
                    Program.UpdateInformation();
                    break;

                case 3: Console.WriteLine("Delete Information" + "\n---------------------");
                    records.Clear();
                    break;

                case 4: Console.WriteLine("Display Information" + "\n---------------------");
                    for (int i = 0; i < records.Count; i++)
                    {
                        Console.WriteLine(records[i] + "\n");
                    }
                    break;
            }

        }

        public static void AddInformation()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Contact Number: ");
            int contactNumber = Convert.ToInt32(Console.ReadLine());
            records.Add("First and Last Name: " + firstName + " " + lastName + "\nAge: " + age + "\nAddress: " + address + "\nContact Number: " + contactNumber + "\n");
        }

        public static void UpdateInformation()
        {
            records.Clear();
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Contact Number: ");
            int contactNumber = Convert.ToInt32(Console.ReadLine());
            records.Add("First and Last Name: " + firstName + " " + lastName + "\nAge: " + age + "\nAddress: " + address + "\nContact Number: " + contactNumber + "\n");
        }


        static void Main(string[] args)
        {
            var lp = new Program();
            do
            {
                Program.LandingPage();
            } while (lp.landingPage == true);

        }
    }
}
