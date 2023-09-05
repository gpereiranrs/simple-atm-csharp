using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class ATMCard
    {
        public string clientName {  get; set; }
        public string[] cardNumber { get; set; }
        public int validationCardYear { get; set; }
        public static void DisplayLogin()
        {
            ATMCard client1 = new ATMCard();
            client1.clientName = "Gabriel";
            client1.cardNumber = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            client1.validationCardYear = 2016;
            client1.CardValidation(client1.cardNumber, client1.validationCardYear);
        }
        public void CardValidation(string[] cardNumber, int cardYear)
        {
            if (cardNumber.GetLength(0) == 10)
            {
                if (cardYear > 2013 && cardYear < 2023)
                {
                    Console.WriteLine($"Welcome, {clientName}");
                }
                else
                {
                    Console.WriteLine("Invalid card number!");
                }
            }
        }
    }
}
