using AutonomousDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    class Program
    {
        static void Main(string[] arg)
        {
            Loop loop = new Loop();
            loop.GameLoop(true);
         
        }
    }
}
