using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourcesLINQ.Test
{
    [TestFixture]
    public class Exercise2LinqTest
    {
        [Test]
        public void CheckResultMethod1()
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            int[] expected = { 1, 3, 6, 9, 10, };
            int from = 1;
            int to = 11;
            Exercise2 actual = new Exercise2(numbers, from, to);
            IEnumerable<int> result = actual.Method1();
            foreach (var item in expected)
            {
                Assert.AreEqual(((IEnumerable<int>)expected).Where(a => a == item), result.Where(a => a == item));
            }
        }

        public void CheckResultMethod2()
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            int[] expected = { 1, 3, 6, 9, 10, };
            int from = 1;
            int to = 11;
            Exercise2 actual = new Exercise2(numbers, from, to);
            IEnumerable<int> result = actual.Method2();
            foreach (var item in expected)
            {
                Assert.AreEqual(((IEnumerable<int>)expected).Where(a => a == item), result.Where(a => a == item));
            }
        }
    }
}