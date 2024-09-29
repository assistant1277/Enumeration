using Enumeration.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeasonSelector.SelectSeason();
            
            Console.WriteLine();

            BeverageSelector.SelectBeverage();

            Console.WriteLine();

            FruitSelector.DisplayAllFruits();

            Console.WriteLine();

            FruitSelector.SelectFruit();
            Console.ReadKey();
        }
    }
}
