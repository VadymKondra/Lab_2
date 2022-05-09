using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Forecast
    {
        Air[] airPerMonth = new Air[30];    
        Water[] waterPerMonth = new Water[30];
    }

    class Air
    {
        double windSpeed;
        double airTemperature;
    }

    class Water
    {
        double waterAmount;
        double waterType;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Forecast forc = new Forecast();
        }
    }
}
