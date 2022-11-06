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
        public void InitiateMenu()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. Print Candies");
                Console.WriteLine("2. Print Meats");
                Console.WriteLine("3. Print Drinks");
                Console.WriteLine("4. Print Veggies");
                Console.WriteLine("5. Buy Candies");
                Console.WriteLine("6. Buy Meats");
                Console.WriteLine("7. Buy Drinks");
                Console.WriteLine("8. Buy Veggies");
                Console.WriteLine("9. Print Shopping Cart");
                Console.WriteLine("10. Buy");
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
                        ShoppingCart.PrintCart();
                        Console.WriteLine("Bought");
                        break;
                }
            }
        }

        public void BuyCandies()
        {
            var selectedCandy = GetSelection();
            var candy = CandyR1.Candies[selectedCandy - 1];
            if (candy is null)
            {
                Console.WriteLine($"Meat with index {selectedCandy - 1} does not exist");
                return;
            }
            ShoppingCart.AddProduct(candy.ToString());
            Console.WriteLine($"Candies with index {selectedCandy - 1} were added to your shopping cart");
        }

        public void BuyMeat()
        {
            var selectedMeat = GetSelection();
            var meat = MeatR1.Meats[selectedMeat - 1];
            if (meat is null)
            {
                Console.WriteLine($"Meat with index {selectedMeat - 1} does not exist");
                return;
            }
            ShoppingCart.AddProduct(meat.ToString());
            Console.WriteLine($"Meat with index {selectedMeat - 1} was added to your shopping cart");
        }

        public void BuyDrinks()
        {
            var selectedDrink = GetSelection();
            var drink = DrinksR1.Drinks[selectedDrink - 1];
            if (drink is null)
            {
                Console.WriteLine($"Meat with index {selectedDrink - 1} does not exist");
                return;
            }
            ShoppingCart.AddProduct(drink.ToString());
            Console.WriteLine($"Drink with index {selectedDrink - 1} was added to your shopping cart");
        }

        public void BuyVeggies()
        {
            var selectedVeggies = GetSelection();
            var veggies = VegetablesR1.Vegetables[selectedVeggies - 1];
            if (veggies is null)
            {
                Console.WriteLine($"Meat with index {selectedVeggies - 1} does not exist");
                return;
            }
            ShoppingCart.AddProduct(veggies.ToString());
            Console.WriteLine($"Veggies with index {selectedVeggies - 1} were added to your shopping cart");
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
