using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanCalisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan span = TimeSpan.Parse("8:30");
            Console.WriteLine(span);
            Console.ReadKey();
        }
    }
}
