using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq: bir metoduz olsun,
            //        parametr olaraq istənilən data tipdən dəyər ala bilməlidi. 
            //        Parametrinə gələn dəyəri çap etsin

            int a = 5;
            string b = "Tural";
            long c = -5;
            double d = 10.25;
            Print(a);
            Print(b);
            Print(c);
            Print(d);
        }
        public static void Print(Object o) 
        {
            Console.WriteLine(o);
        
        
        }
    }
}
