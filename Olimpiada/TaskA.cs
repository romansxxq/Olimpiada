using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiada
{
    class TaskA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); 
            int balance = 0; 
            bool isDebt = false;

            for (int i = 0; i < n; i++)
            {
                string[] action = Console.ReadLine().Split();
                string type = action[0];
                int amount = int.Parse(action[1]);

                if (type == "earn")
                {
                    balance += amount; 
                }
                else if (type == "spend")
                {
                    balance -= amount; 
                }

                if (balance < 0)
                {
                    isDebt = true;
                }
            }

            if (isDebt)
            {
                Console.WriteLine("debt");
            }
            else
            {
                Console.WriteLine("chinazes");
            }
        }
    }
}
