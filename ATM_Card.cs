using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class ATMCard
    {
        public string ClientName {  get; set; }
        public string[] CardNumber { get; set; }
        public int ValidationCardYear { get; set; }

        public void CardData()
        {
            Console.Write("What is your name? ");
            this.ClientName = Console.ReadLine();

            this.CardNumber = new string[10];
            Console.WriteLine("Insert your Card Number:");
            for (int i = 0; i < CardNumber.Length; i++)
            {
                CardNumber[i] = Console.ReadLine();
            }
            Console.WriteLine("Insert your Card Year:");
            this.ValidationCardYear = Convert.ToInt32(Console.ReadLine());
        }
        public void CardValidation()
        {
            if (this.CardNumber.GetLength(0) == 10)
            {
                if (this.ValidationCardYear > 2013 && this.ValidationCardYear < 2023)
                {
                    Console.WriteLine($"Welcome, {ClientName}");
                }
                else
                {
                    Console.WriteLine("Invalid card number!");
                }
            }
        }
    }
}
