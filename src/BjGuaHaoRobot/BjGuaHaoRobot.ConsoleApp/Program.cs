using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjGuaHaoRobot.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => Hospital.GetAreas());
            Console.ReadKey();
        }
    }
}
