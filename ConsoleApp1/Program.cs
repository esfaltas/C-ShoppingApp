using ConsoleApp1;
using ConsoleApp1.Repostitory;

public class Program
{
    public static void Main(string[] args)
    {
        var candyRepository = new CandyR1();
        var meatRepository = new MeatR1();
        var drinkRepository = new DrinksR1();
        var VeggiesRepository = new VegetablesR1();
        var menu = new Menu();
        menu.Start();
    }
}
