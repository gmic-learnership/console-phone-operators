using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            //declaring variables
            string tel = "";
            Boolean isValid;
            Regex regex = new Regex("^[0-9() -]+$");
            tel = tel.Replace("(", "");

            Console.ForegroundColor = ConsoleColor.Cyan;
            while (tel != "!")
            {
                Console.Write("Enter your number \n or press ! to exit \n");
                tel = Console.ReadLine();
                if (regex.IsMatch(tel))
                {
                    isValid = true;
                    if (tel.Contains("(") || tel.Contains(")") || tel.Contains("-") || tel.Contains(" ") || tel.Substring(0, 3) == "012" || tel.Substring(0, 3) == "011" || tel.Substring(0, 3) == "083" || tel.Substring(0, 3) == "072" || tel.Substring(0, 3) == "069" || tel.Substring(0, 3) == "073")
                    { //first IF
                        tel = tel.Replace("(", "");
                        tel = tel.Replace(")", "");
                        tel = tel.Replace("-", "");
                        tel = tel.Replace(" ", "");

                        if (tel.Length == 10)
                        {
                            Console.WriteLine("you dailed " + tel);
                            switch (tel)
                            {
                                case "0831976923":
                                    Console.WriteLine(" Calling vivian ");
                                    break;
                                case "0723456789":

                                    Console.WriteLine("calling Bonginkosi");
                                    break;


                                case "0699876543":
                                    Console.WriteLine("calling Dantani");
                                    break;

                                case "0112345678":
                                    Console.WriteLine("DVT campany");
                                    break;

                                case "0123692581":

                                    Console.WriteLine("DTH company ");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("your number must have only 10 digits!");
                        }



                    }
                    else
                    {
                        Console.WriteLine("Your phone number must start only with 012, 011, 069 or 073");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

                Console.ReadLine();
            }

        }
    }
}
