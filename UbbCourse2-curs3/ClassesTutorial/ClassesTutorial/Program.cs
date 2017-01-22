using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    struct EngineStruct { };
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            //mercedes.StartEngine();
            //mercedes.ShowRemainingNoOfKM(20, 10);
            //mercedes.StartEngine(6);
            mercedes.CalculateConsumption(new int[] { 1, 2, 3, 4 });

            //AbstractCar aCar = new AbstractCar();
            EngineStruct engine = new EngineStruct();
            AbstractCar car2 = new Mercedes();
            Mercedes mercedes2 = new Mercedes();
            Console.WriteLine("This is my first C# project!");
            Console.WriteLine("Mercedes is " + mercedes2.Description);
            Console.WriteLine("Mercedes costs " + mercedes.Price);

            Console.WriteLine("Engine started");
            Console.ReadKey();
        }
    }
}
