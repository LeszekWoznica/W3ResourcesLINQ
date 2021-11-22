using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace W3ResourcesLINQ.Test
{
    [TestFixture]
    public class Exerice1LinqTest
    {
        [Test]
        public void CheckResultMethod1()
        {
            int[] result = new int[4] { 2, 4, 6, 8 };

            var actual = new Exercise1();
            IEnumerable<int> data = actual.Method1();
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(((IEnumerable<int>)result).Where(a => a == result[i]), data.Where(a => a == result[i]));
            }
        }

        [Test]
        public void CheckResultMethod2()
        {
            int[] result = new int[4] { 2, 4, 6, 8 };

            var actual = new Exercise1();
            IEnumerable<int> data = actual.Method2();
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(((IEnumerable<int>)result).Where(a => a == result[i]), data.Where(a => a == result[i]));
            }
        }
    }
}