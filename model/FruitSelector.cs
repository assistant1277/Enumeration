using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration.model
{
    internal class FruitSelector
    {
        //enum representing different fruits
        public enum Fruit
        {
            Apple,
            Banana,
            Orange,
            Mango,
            Pineapple
        }

        //method to display all available fruits
        public static void DisplayAllFruits()
        {
            Console.WriteLine("3) program of fruits selection doing with enumeration concept => \n");
            Console.WriteLine("available fruits are ");

            //we are using loop to go through each fruit in the list and display it
            foreach (Fruit fruit in Enum.GetValues(typeof(Fruit)))
            {
                Console.WriteLine(fruit);
            }
        }

        //this method lets the user pick a fruit by typing its name
        public static void SelectFruit()
        {
            Console.WriteLine("\nenter the name of the fruit you want to select ");
            string fruitInput = Console.ReadLine();

            //using Enum.TryParse to attempt parsing the input to the corresponding enum value and
            //here if the user types Apple fruitInput will hold string and true holds example  "apple", "APPLE", "Apple" will all be treated as valid and afterwards
            //we are checking if the user input matches any fruit from our list
            if (Enum.TryParse(fruitInput, true, out Fruit selectedFruit) && Enum.IsDefined(typeof(Fruit),selectedFruit))
            {
                //if input is valid we show which fruit was selected
                Console.WriteLine($"you selected {selectedFruit}");
            }
            else
            {
                Console.WriteLine("invalid fruit name choose from the list");
            }
        }
    }
}
