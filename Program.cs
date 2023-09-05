using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    class Program
    {
        static void Main(string[] args) 
        {
            ATMCardValidate client1 = new ATMCardValidate();
            client1.clientName = "Gabriel";
            client1.cardNumber = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            client1.validationCardYear = 2016;
            client1.CardValidation(client1.cardNumber, client1.validationCardYear);
        }
    }
}

