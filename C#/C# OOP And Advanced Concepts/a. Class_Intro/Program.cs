using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {

            Human morris = new Human(28, "Morris", "Otieno", "blue");
            Human effie = new Human(32, "Effie", "Otieno", "awesome");
            morris.IntroduceOnceself();
            effie.IntroduceOnceself();
            Console.Read();
        }
    }
}
