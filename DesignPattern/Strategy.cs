using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Strategy
    {
        public Strategy(int initial_value_1, int initial_value_2, Iresult result)
        {
            if (initial_value_2 == 0)
            {
                Console.WriteLine("Division by zero is not defined.");
            }
            else
            {
            int divided = initial_value_1 / initial_value_2;
            int gap = initial_value_1 - initial_value_2 * divided;
            result.Execute(initial_value_1, initial_value_2, divided, gap);
            }
        }
    }
}
