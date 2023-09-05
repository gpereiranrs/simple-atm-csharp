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
            Console.WriteLine("Confirm your PIN password: ");
            string PinAccount = Console.ReadLine();
            if (PinAccount == "1234")
            {
                //implement account painel
            }
            else
            {
                Console.WriteLine("Wrong PIN\n");
            }
        }

        public static void Login()
        {
            int op = 0;
            do
            {
                Console.WriteLine("Choose your option: ");
                Console.WriteLine("\n\t1 Credit Card\n\t2 Debit Card\n\t3 Exit");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ATMCard creditClient = new ATMCard();
                        Console.WriteLine("Insert the current data: ");
                        creditClient.CardData();
                        creditClient.CardValidation();
                        PinValidation();
                        break;
                    case 2:
                        ATMCard debitClient = new ATMCard();
                        Console.WriteLine("Insert the current data: ");
                        debitClient.CardData();
                        debitClient.CardValidation();
                        PinValidation();
                        break;
                    case 3:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
            } while (op != 3);
        }
    }
}
