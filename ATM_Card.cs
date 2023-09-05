using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class ATMCardValidate
    {
        public string clientName {  get; set; }
        public string[] cardNumber { get; set; }
        public int validationCardYear { get; set; }

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
