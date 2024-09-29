using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration.model
{
    internal class BeverageSelector
    {
        //enum represents different types of beverages we can choose from
        public enum Beverages
        {
            Water = 1, //water is the first option labeled as 1
            Coffee,// and coffee will be label as 2
            Tea,
            Soda,
            Juice,
            Milk
        }

        //this is method to get basic information of selected beverage
        public static void GetBeverageDetails(Beverages beverage)
        {
            //show the user what beverage they selected
            Console.WriteLine($"You selected: {beverage}");

            //gives a description for each beverages using ternary conditions
            string beverageInfo = (beverage == Beverages.Water)? "water is important in life keeps you energetic": (beverage == Beverages.Coffee)? "coffee is popular drink known for its caffeine": (beverage == Beverages.Tea)? "tea is enjoyed worldwide and famous in india and there are many types of tea like green,black,etc": (beverage == Beverages.Soda)? "soda is carbonated drink which includes various flavours of orange,mango,lime and with sugar ": (beverage == Beverages.Juice)? "juice made from fruits or vegetables and is rich in vitamins,proteins,etc ":"milk is a great source of calcium and can be used to make tea,coffee";

            Console.WriteLine(beverageInfo);
        }

        //method to select beverage based on user input
        public static void SelectBeverage()
        {
            Console.WriteLine("2) program of beverage selection doing with enumeration concept \n");
            Console.WriteLine("Please select a beverage by entering a number(1 for water, 2 for coffee, 3 for tea, 4 for soda, 5 for juice, 6 for milk) ");
            int userChoice = int.Parse(Console.ReadLine());

            //validating means ensure it is within the range of 1-6
            if (userChoice < 1 || userChoice > 6)
            {
                Console.WriteLine("invalid choice select number between 1-6");
                return;//exit this method
            }

            //convert user input to the corresponding enum value
            Beverages selectedBeverage = (Beverages)userChoice;

            //getting and display the beverage info
            GetBeverageDetails(selectedBeverage);
        }
    }
}
