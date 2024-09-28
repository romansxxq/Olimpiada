using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiada
{
    class TaskH
    {
        static void Main()
        {
            string[] value = Console.ReadLine().Split(' ');
            int a = int.Parse(value[0]);
            int b = int.Parse(value[1]);
            int c = int.Parse(value[2]);

            int zagalnaSuma = (a >= b) ? a : a + c;

            Console.WriteLine(zagalnaSuma);
            Console.ReadKey();
        }
    }
}
