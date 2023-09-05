using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class CashAvailable
    {
        public double totalCash {  get; set; }
        public void ShowCash(double cash)
        {
            totalCash = cash;
            Console.WriteLine($"Cash Available:{totalCash}");
        }
    }
}
