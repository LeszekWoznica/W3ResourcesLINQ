using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourcesLINQ
{
    public class Exercise2
    {
        private int[] Numbers;
        private int From, To;

        //The numbers within the range of 1 to 11 are :
        public Exercise2(int[] numbers, int from, int to)
        {
            Numbers = numbers;
            From = from;
            To = to;
        }

        public IEnumerable<int> Method1()
        {
            return from number in Numbers
                   where number >= From
                   where number <= To
                   select number;
        }

        public IEnumerable<int> Method2()
        {
            return Numbers.Where(a => a >= From & a >= To);
        }
    }
}