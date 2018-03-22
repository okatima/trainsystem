using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainsystem.model.trains;

namespace Trainsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricTrain electricTrain = new ElectricTrain(1, "Alco-GE", 1949, ElectricTrain.CurrentTypes.Alternating);
            Console.WriteLine("Electric train ID:" + electricTrain.ID + " Name:" + electricTrain.Name);
            Console.ReadLine();
        }
    }
}
