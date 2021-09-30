using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(String[] args)
        {
            Calculate obj = new Calculate();

            int sum2 = obj.Add(1, 2);
            Console.WriteLine("{0}", sum2);


            int sum3 = obj.Add(1, 2, 3);
            Console.WriteLine("{0}", sum3);
        }
    }
}

