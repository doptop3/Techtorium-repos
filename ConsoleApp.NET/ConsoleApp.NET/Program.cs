using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
using System.Configuration;

namespace NewProject
{
    internal class Program
    {
        private const string Path = @"c:\temp\text.txt";

        public bool landingpage = true;
        static List<string> records = new List<string>();
        private static void LandingPage()
        {          
            Console.WriteLine("==========Student Information==========");

            Console.WriteLine("1. Add Information");
            Console.WriteLine("2. Insert Information");
            Console.WriteLine("3. Update Student Information");
            Console.WriteLine("4. Delete Student Information");
            Console.WriteLine("5. Search Student Information");
            Console.WriteLine("6. Display Student Information");

            int Nav = Convert.ToInt16(Console.ReadLine());

            switch (Nav)
            {
                case 1:
                    Console.WriteLine("Add information");
                    Program.AddInformation();
                    break;

                case 2:
                    Console.WriteLine("Inserted Information");
                    for (int i = 0; i < records.Count; i++)
                    {
                        Console.WriteLine(records[i] + "\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("Updated Information");
                    Program.UpdateInformation();
                    break;

                case 4:
                    Console.WriteLine("Deleted Information");
                    records.Clear();
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.WriteLine("Search Information");
                    string target = Console.ReadLine();
                    bool isExist = records.Contains(target);
                    if (isExist)
                    {
                        Console.WriteLine("Element found in the list");
                    }
                    else
                    {
                        Console.WriteLine("Element not found in the given list");
                    }
                    break;

                case 6:
                    Console.WriteLine("Displayed Information");
                    Program.DisplayInformation();
                    break;

                default:
                    Console.WriteLine("incorrect input");
                    break;
            }
        } 

        public static void AddInformation()
        {
            Console.WriteLine("Adding information function to add students details");
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            string lastName = Console.ReadLine();
            records.Add(firstName + " " + lastName);
        }
        public static void UpdateInformation()
        {
            Console.WriteLine("Adding information function to add students details");
            Console.WriteLine("Enter first name");
            string firstName2 = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            string lastName2 = Console.ReadLine();
            records.Add(firstName2 + " " + lastName2);
        }

        public static void DisplayInformation()
        {
            for (int i = 0; i < records.Count; i++)
            {
                Console.WriteLine(records[i] + "\n");
            }

            FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (string a in records)
            sw.WriteLine(a);

            sw.Flush();

            sw.Close();

            //file handling-read
            Console.WriteLine("Read data from file");
            FileStream fsRead = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader srRead = new StreamReader(fsRead);
            Console.WriteLine(srRead.ReadLine());
            srRead.Close();
        }

        public static void rockpaperscissorsgame()
        {
            Random random = new Random();

            Console.WriteLine("\nHand: 1");
            Console.WriteLine("scissors: 2");
            Console.WriteLine("rock: 3");

            byte rockpaperscissors = Convert.ToByte(Console.ReadLine());
            bool negative = rockpaperscissors <= 0;
            bool positive = rockpaperscissors >= 4;

            while (negative == false && positive == false)
            {
                byte num = Convert.ToByte(random.Next(1, 4));
                Console.WriteLine(num + "\n");

                return;
            }           
        }
        public static void Main(string[] args)
        {   
            var lp = new Program();
            do
            {
                Program.LandingPage();
            } while (lp.landingpage == true);

            Program.rockpaperscissorsgame();

            Console.WriteLine("what mark did you get: ");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("C");
            Console.WriteLine("D");
            Console.WriteLine("E");

            ConsoleKeyInfo keyInfo;

            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("You scored between 80.00 - 100.00\n");
                    break;
                case ConsoleKey.B:
                    Console.WriteLine("You scored between 65.00 - 79.99\n");
                    break;
                case ConsoleKey.C:
                    Console.WriteLine("You scored between 50.00 - 64.99\n");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("You scored between 30.00 - 49.99\n");
                    break;
                case ConsoleKey.E:
                    Console.WriteLine("You scored between 0.00 - 29.99\n");
                    break;
                default:

                    break;
            }

            Console.WriteLine("Is your inputed number odd or even: ");
            byte oddoreven = Convert.ToByte(Console.ReadLine());

            if (oddoreven % 2 == 0)
            {
                Console.WriteLine("even\n");
            }
            else if (oddoreven % 2 > 0)
            {
                Console.WriteLine("odd\n");
            }
            else { Console.WriteLine("null\n"); }

            Console.WriteLine("Positive number or negative number?");
            int numposneg = Convert.ToInt32(Console.ReadLine());
            if (numposneg >= 0)
            {
                Console.WriteLine("number is positive\n");
            }
            else if (numposneg < 0)
            {
                Console.WriteLine("number is negative\n");
            }
            else { Console.WriteLine("null"); }

            Console.WriteLine("can you vote: ");
            int votingage = Convert.ToInt32(Console.ReadLine());
            if (votingage >= 18)
            {
                Console.WriteLine("you can vote\n");
            } else if (votingage < 18)
            {
                Console.WriteLine("you can't vote\n");
            } else { Console.WriteLine("null\n"); }

            Console.WriteLine("David is 19 years old and Luke is 17 years old. Develop a code to check by how many years Luke is younger than David.");
            Console.WriteLine("David age: ");
            byte Davidage = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Luke age: ");
            byte Lukeage = Convert.ToByte(Console.ReadLine());

            if (Davidage - Lukeage >= 0)
            {
                Console.WriteLine("David is " + (Davidage - Lukeage) + " years older than Luke\n");
            }
            else if (Davidage - Lukeage < 0)
            {
                Console.WriteLine("Luke is " + (Lukeage - Davidage) + " years older than David\n");
            }
            else { Console.WriteLine("null"); }

            int num, reverse = 0, rem;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse + "\n");

            Console.WriteLine($"Name: ");
            string Name = Convert.ToString(Console.ReadLine()); //string
            Console.WriteLine($"High School: ");
            string Highschool = Convert.ToString(Console.ReadLine()); //string
            Console.WriteLine($"Techtorium ID: ");
            ushort TechtoriumID = Convert.ToUInt16(Console.ReadLine()); //ushort (same as uint16) 0 to 65,535
            Console.WriteLine($"Trainer Name: ");
            string TrainerName = Convert.ToString(Console.ReadLine()); //string
            Console.WriteLine($"Contact Number: ");
            string ContactNumber = Convert.ToString(Console.ReadLine()); //string
            Console.WriteLine($"Hobbies: ");
            string Hobbies = Convert.ToString(Console.ReadLine()); //string
            Console.WriteLine("\nYour information: ");
            Console.WriteLine(Name);
            Console.WriteLine(Highschool);
            Console.WriteLine(TechtoriumID);
            Console.WriteLine(TrainerName);
            Console.WriteLine(ContactNumber);
            Console.WriteLine(Hobbies + "\n");

            Console.WriteLine("Rating myself");
            Console.WriteLine("Confidence: 6");
            Console.WriteLine("Creativity: 8");
            Console.WriteLine("Resilience: 9");
            Console.WriteLine("Positivity: 7");
            Console.WriteLine("Hard Work: 6");
            Console.WriteLine("Love for Programming: 8\n");       

            Console.WriteLine(" __");
            Console.WriteLine("|__|");

            Console.WriteLine(" ___");
            Console.WriteLine("|___|");

            Console.WriteLine(" ___");
            Console.WriteLine("/__/");

            Console.WriteLine("__");
            Console.WriteLine("\\/\n");

            Console.WriteLine("\nTechtorium felt appealing as the aplications being used were highly demanded in the industry. And the trainers were helpful in understanding what we would be doing.\n");

            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            decimal calculate = decimal.Parse(Console.ReadLine());
            decimal a, b, c;
            switch (calculate)
            {
                case 1:
                    Console.Write("Enter A: ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;
                case 2:
                    Console.Write("Enter A: ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter A: ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter A: ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                    break;
                default:
                    Console.WriteLine("null");
                    break;
            }
        }
    }   
}
