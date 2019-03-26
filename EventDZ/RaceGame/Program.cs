using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace hw13
{
    class Program
    {
        static void Main(string[] args)
        {
            Game race = new Game();
            race.Start();  
            Console.ReadLine();
        }
    }
}