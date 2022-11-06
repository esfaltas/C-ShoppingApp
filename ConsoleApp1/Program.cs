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
        Console.WriteLine("Deposit money to buy");
        int number;
        string money = Console.ReadLine();
        Console.WriteLine("");
        bool isNumerical = int.TryParse(money, out number);

        if (Convert.ToDouble(number) > 0)
        {
            Console.WriteLine("Your wallet: " + number);
            menu.InitiateMenu();
        }
        else if(Convert.ToDouble(number) == 0)
        {
            menu.InitiateMenu();
        }
        else
        {
            Console.WriteLine("That is not a valid currency");
            Main(args);
        }
    }
}
