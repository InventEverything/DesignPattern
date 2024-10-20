using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Remainder : Iresult
    {
        public void Execute(int initial_value_1, int initial_value_2, int divided, int gap)
        {
            string answer = ("Remainder result: " + divided + " remainder " + gap);
            Console.WriteLine(answer);
        }
    }
}
