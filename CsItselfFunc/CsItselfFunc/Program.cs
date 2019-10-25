using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CsItselfFunc
{
    class Program
    {
        public delegate int SomeOperation(int i, int j);

        //Func is built-in delegate type.
        //Func delegate type must return a value.
        //Func delegate type can have zero to 16 input parameters.
        //Func delegate does not allow ref and out parameters.
        //Func delegate type can be used with an anonymous method or lambda expression.

        static void Main(string[] args)
        {
            SomeOperation add = Sum;

            int result = add(2, 3);
            Console.WriteLine(result);

            Func<int, int, int> add_v2 = Sum;
            int result_2 = add_v2(10, 20);
            Console.WriteLine(result_2);

            Func<int> getRandomNumber = delegate()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber.Invoke());



            Func<int> getRandomNumber_2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber_2.Invoke());

            Func<int, int, int> sum = (x, y) => x + y;
            Console.WriteLine(sum.Invoke(200,300));


            Func<int, int, int, DateTime> createDateTime = (day, month, year) => new DateTime(year, month,day);
            Console.WriteLine(createDateTime(1,9,2019));

        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
