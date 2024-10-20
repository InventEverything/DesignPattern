using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Decimal : Iresult
    {
        public void Execute(int initial_value_1, int initial_value_2, int divided, int gap)
        {
            string answer = ("Decimal result: " + (divided + gap / (decimal)initial_value_2));
            Console.WriteLine(answer);
        }
    }
}
