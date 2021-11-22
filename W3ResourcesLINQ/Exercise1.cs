using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourcesLINQ
{
    //    Write a program in C# Sharp to shows how the three parts of a query operation execute. Go to the editor
    //Expected Output:
    //The numbers which produce the remainder 0 after divided by 2 are :
    //0 2 4 6 8
    public class Exercise1
    {
        private int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public IEnumerable<int> Method1()
        {
            IEnumerable<int> nQuery = from number in numbers
                                      where (number % 2) == 0
                                      select number;

            return nQuery;
        }

        public IEnumerable<int> Method2()
        {
            IEnumerable<int> list = (IEnumerable<int>)numbers;
            return list.Where(r => r % 2 == 0);
        }

        public void ShowResult()
        {
            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            IEnumerable<int> result = Method1();
            foreach (int number in result)
            {
                Console.Write("{0}", number);
            }
            Console.Write("\n\n");
            result = Method2();
            foreach (int number in result)
            {
                Console.Write("{0}", number);
            }
            Console.Write("\n\n");
        }
    }
}