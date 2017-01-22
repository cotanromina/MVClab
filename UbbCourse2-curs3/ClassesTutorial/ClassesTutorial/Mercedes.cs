using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
 
    public class Mercedes : AbstractCar
    {
        public string Description;
        public int Price;
        //private string _description;
        //private int _price;
        //protected string _description;
        //protected int _price;
        //internal string _description;
        //internal int _price;
        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
            Console.ReadKey();
        }

        public void ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            Console.WriteLine("Remaining km: "+ noOfFuelLiters / Consumption *100);
            Console.ReadKey();
        }
       
        public void StartEngine(int nrOfMilliseconds)
        {
            Console.WriteLine("The car is starting  in " + nrOfMilliseconds + " milliseconds");
            Console.ReadKey();
        }
        
        public double CalculateConsumption(params int[] kms)
        {
            double sum = 0;
            foreach (int km in kms)
                sum += km;
            return sum / 100 * 7;
        }
    }

}
