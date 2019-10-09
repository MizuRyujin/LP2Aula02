using System;

namespace Tuples
{
    class Program
    {
        private static Random rnd;

        static void Main(string[] args)
        {
            rnd = new Random();
            Stuff s;
            Tuple<int, double, bool> tp;
            int i;
            double d;
            bool b;

            Object[] objs = GetStuff1();


            Console.WriteLine("First method to get stuff");
            foreach (Object obj in objs)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            Console.WriteLine("Second method to get stuff");
            s = GetStuff2();
            Console.WriteLine($"Int = {s.Intager}, " +
                $"Double = {s.Double}, " +
                $"Bool = {s.Bool}");

            Console.WriteLine();

            Console.WriteLine("Third method to get stuff");
            GetStuff3(out i, out d, out b);
            Console.WriteLine($"Int = {i}, " +
                $"Double = {d}, " +
                $"Bool = {b}");

            Console.WriteLine();

            Console.WriteLine("Fourth method to get stuff");
            tp = GetStuff4();
            Console.WriteLine($"Tuple's int:{tp.Item1}");
            Console.WriteLine($"Tuple's int:{tp.Item2}");
            Console.WriteLine($"Tuple's int:{tp.Item3}");
        }

        // Static Methods
        private static Object[] GetStuff1()
        {
            Object[] objs = new Object[3];
            objs[0] = rnd.Next();
            objs[1] = rnd.NextDouble();
            objs[2] = rnd.NextDouble() < 0.5f;

            return objs;
        }

        private static Stuff GetStuff2()
        {
            return new Stuff(rnd.Next(), rnd.NextDouble(),
                rnd.NextDouble() < 0.5f);
        }

        private static void GetStuff3(out int i, out double d, out bool b)
        {
            i = rnd.Next();
            d = rnd.NextDouble();
            b = rnd.NextDouble() < 0.5f;
        }

        private static Tuple<int, double, bool> GetStuff4()
        {
            Tuple<int, double, bool> t = new Tuple<int, double, bool>
                (rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5f);

            return t;
        }
    }
}
