using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GrandCircusLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            string phone;
            string date;

            while (true)
            {
                //check for valid NAME
                Console.WriteLine("Please enter your name ('Firstname Lastname')");

                name = Console.ReadLine();

                if (CheckName(name) == false || name.Length > 30)
                {
                    Console.WriteLine("Please only use alphabets, have first and last names start with Upper Case, and max length of 30!");
                    continue;
                }
                else
                {
                    Console.WriteLine("NAME IS VALID!  <<<<<\n");
                    break;
                }
            }

            while(true)
            {
                //check for valid EMAIL
                Console.WriteLine("Please enter your email (example@gmail.com)");

                email = Console.ReadLine();

                if ((CheckEmail(email)) == false)
                {
                    Console.WriteLine("Please only use an email that has a begining word 5-30 alphanumeric characters\n" +
                                      "Has an '@' symbol\nHas a host name of 5-10 alphanumeric characters\nHas and a '.domain' of 2-3 letters");
                    continue;
                }
                else
                {
                    Console.WriteLine("EMAIL IS VALID!  <<<<<\n");
                    break;
                }
            }

            while(true)
            {
                //check for valid PHONE NUMBER
                Console.WriteLine("Please enter your phone number (###-###-####)");

                phone = Console.ReadLine();

                if ((CheckPhone(phone)) == false)
                {
                    Console.WriteLine("Please only use a valid number with valid area code (###-###-####)");
                    continue;
                }
                else
                {
                    Console.WriteLine("PHONE NUMBER IS VALID!  <<<<<\n");
                    break;
                }
            }

            while(true)
            {
                //check for valid DATE
                Console.WriteLine("Please enter a date (##/##/####)");

                date = Console.ReadLine();

                if ((CheckDate(date)) == false)
                {
                    Console.WriteLine("Please only use a valid date typed as day/month/year (##/##/####)");
                    continue;
                }
                else
                {
                    Console.WriteLine("DATE IS VALID!  <<<<<\n");
                    break;
                }
            }
            Console.WriteLine("ENTER to exit");
            Console.ReadLine();
        }

        //-------------------------------------here thar be methods!------------------------------------------------------

        static bool CheckName(string name)
        {
            //checks to see if name meets requirements, returns true or false
            //made take a valid Firstname and Lastname with regex
            if (Regex.IsMatch(name, @"^[A-Z][a-z]+\s[A-Z][a-z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static bool CheckEmail(string email)
        {
            //checks to see if email meets requirements, returns true or false
            if (Regex.IsMatch(email, @"^[a-zA-Z0-9]{5,30}\@[a-zA-Z0-9]{5,10}\.[A-Za-z]{2,3}$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        static bool CheckPhone(string phone)
        {
            //checks to see if phone is valid, returns true or false
            //used RegEx to prevent area code starting with 0
            if (Regex.IsMatch(phone, @"^[1-9][0-9]{2}\-[0-9]{3}\-[0-9]{4}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
        static bool CheckDate(string date)
        {
            //checks to see if date is valid, returns true or false. 
            //used RegEx to eliminate some non-sensical dates - ex. days starting with a 4# or higher, months starting with 2# or higher

            if (Regex.IsMatch(date, @"^[0-3][0-9]\/[0-1][0-9]\/[0-9]{4}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
