using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(false);
            Console.ReadKey();
        }
    }
}
