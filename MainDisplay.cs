using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class MainDisplay
    {
        public static void PinValidation()
        {
            Console.WriteLine("Hi, what is your account PIN");
            int i = 3;
            while (i > 0)
            {
                string PinAccount = Console.ReadLine();
                    if (PinAccount == "1234")
                    {
                        Login();
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong PIN");
                    }
                i--;              
            }
    }
        public static void Login()
        {
            Console.WriteLine("Choose your option: ");
            Console.WriteLine("\n\t1 Credit Card\n\t2 Debit Card\n\t3 Exit");
            int op = Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    ATMCard c1 = new ATMCard();
                    Console.WriteLine("Insert the current data: ");
                    c1.CardData();
                    c1.CardValidation();
                    break;
                case 2:
                    ATMCard c2 = new ATMCard();
                    Console.WriteLine("Insert the current data: ");
                    c2.CardData();
                    c2.CardValidation();
                    break;
                case 3:
                    Console.WriteLine("Bye!");
                    break;
            }
        }
    }
}
