using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;
using ConsoleApp1.Repostitory;

namespace ConsoleApp1
{
    internal class Menu
    {
        int number;
        public void Start()
        {
            var menu = new Menu();
            Console.WriteLine("Deposit money to buy");
            string money = Console.ReadLine();
            Console.WriteLine("");
            bool isNumerical = int.TryParse(money, out number);
            while (isNumerical)
            {
                if (Convert.ToDouble(number) > 0)
                {
                    Console.WriteLine("Your wallet: " + number);
                    InitiateMenuAndBuy();
                }
                else if (Convert.ToDouble(number) == 0)
                {
                    InitiateMenu();
                }
            }
            {
                Console.WriteLine("That is not a valid currency");
                Start();
            }
        }

        public void InitiateMenu()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. See Candies");
                Console.WriteLine("2. See Meats");
                Console.WriteLine("3. See Drinks");
                Console.WriteLine("4. See Veggies");
                Console.WriteLine("5. Exit");
                var input = GetSelection();
                switch (input)
                {
                    case 0:
                        continue;
                    case 1:
                        PrintCandies();
                        break;
                    case 2:
                        PrintMeats();
                        break;
                    case 3:
                        PrintDrinks();
                        break;
                    case 4:
                        PrintVeggies();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for visiting");
                        System.Environment.Exit(0);
                        break;
                }
            }
        }

        public void InitiateMenuAndBuy()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. See Candies");
                Console.WriteLine("2. See Meats");
                Console.WriteLine("3. See Drinks");
                Console.WriteLine("4. See Veggies");
                Console.WriteLine("5. Add Candies to cart");
                Console.WriteLine("6. Add Meat to cart");
                Console.WriteLine("7. Add Drinks to cart");
                Console.WriteLine("8. Add Veggies to cart");
                Console.WriteLine("9. Check Shopping Cart");
                Console.WriteLine("10. Buy");
                Console.WriteLine("11. Exit");
                var input = GetSelection();
                switch (input)
                {
                    case 0:
                        continue;
                    case 1:
                        PrintCandies();
                        break;
                    case 2:
                        PrintMeats();
                        break;
                    case 3:
                        PrintDrinks();
                        break;
                    case 4:
                        PrintVeggies();
                        break;
                    case 5:
                        BuyCandies();
                        break;
                    case 6:
                        BuyMeat();
                        break;
                    case 7:
                        BuyDrinks();
                        break;
                    case 8:
                        BuyVeggies();
                        break;
                    case 9:
                        ShoppingCart.PrintCart();
                        break;
                    case 10:
                        ShoppingCart.CountTotal();
                        Console.WriteLine("Thank you for buying");
                        break;
                    case 11:
                        Console.WriteLine("Thank you for visiting");
                        System.Environment.Exit(0);
                        break;
                }
            }
        }

        public void BuyCandies()
        {
            Console.WriteLine("Choose the number of candy you want to add to the cart:");
            var selectedCandy = GetSelection();
            var candy = CandyR1.Candies[selectedCandy - 1];
            if (candy is null || number < 0 || candy.Price > number)
            {
                Console.WriteLine($"Candy with index {selectedCandy - 1} does not exist or you do not have enough money"); //gal cia prasukt while loopa kad turet skirtingus options
                return;
            }
            else
            {
                ShoppingCart.AddProduct(candy.ToString());
                decimal CountTotal = number - candy.Price;
                Console.WriteLine($"Candy with index {selectedCandy - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                decimal CountTotal1 = CountTotal;
                number = (int)CountTotal1;
            }
        }

        public void BuyMeat()
        {
            Console.WriteLine("Choose the number of meat you want to add to the cart:");
            var selectedMeat = GetSelection();
            var meat = MeatR1.Meats[selectedMeat - 1];
            if (meat is null || number < 0 || meat.Price > number)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 1} does not exist or you do not have enough money"); 
                return;
            }
            else
            {
                ShoppingCart.AddProduct(meat.ToString());
                decimal CountTotal = number - meat.Price;
                Console.WriteLine($"Meat with index {selectedMeat - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                decimal CountTotal1 = CountTotal;
                number = (int)CountTotal1;
            }
        }

        public void BuyDrinks()
        {
            Console.WriteLine("Choose the number of drink you want to add to the cart:");
            var selectedDrink = GetSelection();
            var drink = DrinksR1.Drinks[selectedDrink - 1];
            if (drink is null || number < 0 || drink.Price > number)
            {
                Console.WriteLine($"Meat with index {selectedDrink - 1} does not exist or you do not have enough money");
                return;
            }
            else
            {
                ShoppingCart.AddProduct(drink.ToString());
                decimal CountTotal = number - drink.Price;
                Console.WriteLine($"Meat with index {selectedDrink - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                decimal CountTotal1 = CountTotal;
                number = (int)CountTotal1;
            }
        }

        public void BuyVeggies()
        {
            Console.WriteLine("Choose the number of veggies you want to add to the cart:");
            var selectedVeggies = GetSelection();
            var veggies = VegetablesR1.Vegetables[selectedVeggies - 1];
            if (veggies is null || number < 0 || veggies.Price > number)
            {
                Console.WriteLine($"Meat with index {selectedVeggies - 1} does not exist or you do not have enough money");
                return;
            }
            else
            {
                ShoppingCart.AddProduct(veggies.ToString());
                decimal CountTotal = number - veggies.Price;
                decimal Price1 = veggies.Price;
                Console.WriteLine($"Meat with index {selectedVeggies - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                decimal CountTotal1 = CountTotal;
                number = (int)CountTotal1;
            }
        }

        public void PrintCandies()
        {
            foreach (Candy candy in CandyR1.Candies)
            {
                Console.WriteLine(candy);
            }
        }

        public void PrintMeats()
        {
            foreach (Meat meat in MeatR1.Meats)
            {
                Console.WriteLine(meat);
            }
        }

        public void PrintDrinks()
        {
            foreach (Drinks drink in DrinksR1.Drinks)
            {
                Console.WriteLine(drink);
            }
        }
        public void PrintVeggies()
        {
            foreach (Vegetables veggie in VegetablesR1.Vegetables)
            {
                Console.WriteLine(veggie);
            }
        }

        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Wrong format");
            return 0;
        }
    }
}
