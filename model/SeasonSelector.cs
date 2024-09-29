using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class SeasonSelector
    {
        
        //enum represents the different seasons of the year
        public enum Seasons
        {
            Spring=1, //spring is the first season label as 1
            Summer, // and summer will label as 2
            Autumn, // 3 for autumn
            Winter //4 for winter
        }

        //method provides information about the selected season
        public static void GetSeasonDetails(Seasons season)
        {
            //show the user what season they selected
            Console.WriteLine($" you selected {season}");

            //gives a description for each season using ternary conditions
            string seasonInfo = (season == Seasons.Spring) ? "mild temperatures in spring" : (season == Seasons.Summer) ? "hot temperature and vacations period in summer" : (season == Seasons.Autumn) ? "cooler weather autumn is" : "winter is coldest season";
        
            Console.WriteLine(seasonInfo );
        }


        //method allows the user to select a season by entering a number
        public static void SelectSeason()
        {
            Console.WriteLine("1) program of season selection doing with enumeration concept \n");
            Console.WriteLine("select a season by entering number(1 for spring, 2 for summer, 3 for autumn, 4 for winter) ");
            int userChoice=int.Parse(Console.ReadLine()); //get the user choice and convert it to an integer

            //validating means ensure it is within the range of 1-4
            if (userChoice<1 || userChoice > 4)
            {
                Console.WriteLine("invalid choice select number between 1-4");
                return; //exit this method
            }

            //convert user input to corresponding enum value
            Seasons selectedseason = (Seasons)userChoice;

            //getting and display the season info
            GetSeasonDetails(selectedseason);
        }

    }
}
