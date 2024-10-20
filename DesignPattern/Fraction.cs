using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Fraction : Iresult
    {
        public void Execute(int initial_value_1, int initial_value_2, int divided, int gap)
        {
            string answer;
            if (gap == 0)
            {
                answer = ("Fraction result: " + divided);
            }
            else
            {
                answer = ("Fraction result: " + (divided + " and " + gap + "/" + initial_value_2));
            }
            Console.WriteLine(answer);
        }
    }
}
