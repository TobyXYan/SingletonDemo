using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => GetS1Message(),
                () => GetS2Message());
            Console.ReadLine();
        }

        private static void GetS2Message()
        {
            var s2 = Singleton.Instance;
            s2.PrintDetails("From S2 Message");
        }

        private static void GetS1Message()
        {
            var s1 = Singleton.Instance;
            s1.PrintDetails("From S1 Message");
        }
    }
}
