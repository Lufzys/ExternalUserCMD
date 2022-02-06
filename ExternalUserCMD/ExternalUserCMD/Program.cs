using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalUserCMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Valve Games - Execute Command";
        start:

            Console.Clear();
            Console.Write("\n");
            Console.Write("  Write Command : ");
            UserCMD.Execute(Console.ReadLine());

            goto start;

        }
    }
}
