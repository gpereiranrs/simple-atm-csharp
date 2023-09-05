using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class UserAccountPainel
    {
        public void MainPainel()
        {
            CashAvailable client = new CashAvailable();
            int op = 0;
            do
            {
                Console.WriteLine("Choose your option: ");
                Console.WriteLine("\n\t1 Cash Availability\n\t2 Transactions historic\n\t3 Withdraw\n\t4 Exit");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        client.ShowCash(100.10);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        break;
                }
            } while (op != 4);
        }
    }
}

