using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample {

    class Program {

        static void Main(string[] args) {
            int x = 20;
            Console.WriteLine(string.Format("x={0} is Even number: {1}", x, x.isEvenNumber()));
            Console.Read();
        }

    }

    static class ExtensionTest {

        public static bool isEvenNumber(this int a) {
            return a % 2 == 0 ? true : false;
        }

    }

}
