using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            string tel = Console.ReadLine();
            while (tel != "!")
            { 
            Console.WriteLine("Please enter the the number you wish to dial");
            Console.ForegroundColor = ConsoleColor.White;
             tel = Console.ReadLine();

            if (tel.Contains("(") || tel.Contains(")") || tel.Contains("-") || tel.Contains(" ") || tel.Substring(0, 3) == "012" || tel.Substring(0, 3) == "011" || tel.Substring(0, 3) == "083" || tel.Substring(0, 3) == "072" || tel.Substring(0, 3) == "069" || tel.Substring(0, 3) == "073")
            { //first IF
                tel = tel.Replace("(", "");
                tel = tel.Replace(")", "");
                tel = tel.Replace("-", "");
                tel = tel.Replace(" ", "");
                //Console.WriteLine("successfully Dialling" + " " + tel);

                tel.Trim();
                double Num;
                bool isNum = double.TryParse(tel, out Num);

                if (isNum)
                {// second IF
                    if (tel.Length == 10)
                    { //third IF
                        Console.WriteLine("Successfully Dialling " + tel);



                        //this a numbers that are saved in the program
                        if (tel == "0831976923")
                        {
                            Console.WriteLine(" Calling vivian ");
                        }
                        if (tel == "0723456789")
                        {
                            Console.WriteLine("calling Bonginkosi");
                        }


                        if (tel == "0699876543")
                        {
                            Console.WriteLine("calling Dantani");
                        }

                        if (tel == "0112345678")
                        {
                            Console.WriteLine("DVT campany");
                        }

                        if (tel == "0123692581")
                        {
                            Console.WriteLine("DTH company ");
                        }
                    }
                    else
                    { // third else(IF)
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Check the number and try again");
                        Console.Beep();
                    }// third ELSE (IF)




                }// Second aIF

                else
                { // second ELSE (if)
                    Console.WriteLine("tel can only contain numeric values");
                }//Second ELSE
            } // first IF




            Console.ReadLine();
        }


        }
    }
}
