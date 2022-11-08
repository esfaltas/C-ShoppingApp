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
        int wallet;
        public void Start()
        {
            Console.WriteLine("Deposit money to buy");
            string money = Console.ReadLine();
            Console.WriteLine("");
            bool isNumerical = int.TryParse(money, out wallet);
            while (isNumerical)
            {
                if (Convert.ToDouble(wallet) > 0)
                {
                    Console.WriteLine("Your wallet: " + wallet);
                    InitiateMenuAndBuy();
                }
                else if (Convert.ToDouble(wallet) == 0)
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
                Console.WriteLine(" ");
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
                    default:
                        Console.WriteLine("Not a valid entry");
                        break;
                }
            }
        }

        public void InitiateMenuAfter()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.WriteLine("1. See Candies");
                Console.WriteLine("2. See Meats");
                Console.WriteLine("3. See Drinks");
                Console.WriteLine("4. See Veggies");
                Console.WriteLine("5. Check shopping cart");
                Console.WriteLine("6. Buy shopping cart");
                Console.WriteLine("7. Exit");
                var input = GetSelection();
                Console.WriteLine(" ");
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
                        ShoppingCart.PrintCart();
                        ShoppingCart.PrintCost();
                        break;
                    case 6:
                        ShoppingCart.PrintCart();
                        ShoppingCart.PrintCost();
                        BuyCart();
                        break;
                    case 7:
                        Console.WriteLine("Thank you for visiting");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid entry");
                        break;
                }
            }
        }

        public void InitiateMenuAndBuy()
        {
            while (wallet >= 10)
            {
                Console.WriteLine("1. See Candies");
                Console.WriteLine("2. See Meats");
                Console.WriteLine("3. See Drinks");
                Console.WriteLine("4. See Veggies");
                Console.WriteLine("5. Add Candies to shopping cart");
                Console.WriteLine("6. Add Meats to shopping cart");
                Console.WriteLine("7. Add Drinks to shopping cart");
                Console.WriteLine("8. Add Veggies to shopping cart");
                Console.WriteLine("9. Check shopping cart");
                Console.WriteLine("10. Buy shopping cart");
                Console.WriteLine("11. Exit");
                var input = GetSelection();
                Console.WriteLine(" ");
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
                        ShoppingCart.PrintCost();
                        break;
                    case 10:
                        ShoppingCart.PrintCart();
                        ShoppingCart.PrintCost();
                        BuyCart();
                        break;
                    case 11:
                        Console.WriteLine("Thank you for visiting");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid entry");
                        break;
                }
            }
            InitiateMenuAfter();
        }

        public void BuyCandies()
        {
            PrintCandies();
            Console.WriteLine("Choose the number of candy you want to add to the cart:");
            var selectedCandy = GetSelection();
            Console.WriteLine(" ");
            var candy = CandyR1.Candies[selectedCandy - 1];
            if (candy is null || wallet >= candy.Price)
            {
                ShoppingCart.AddProduct(candy);
                decimal CountTotal = wallet - candy.Price;
                Console.WriteLine($"Candy with index {selectedCandy - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                Console.WriteLine(" ");
                decimal CountTotal1 = CountTotal;
                wallet = (int)CountTotal1;

            }
            else if (candy.Price > wallet)
            {
                Console.WriteLine($"Candy with index {selectedCandy - 1} is too expensive or does not exist");
                Console.WriteLine(" ");
            }
        }

        public void BuyMeat()
        {
            PrintMeats();
            Console.WriteLine("Choose the number of meat you want to add to the cart:");
            var selectedCandy = GetSelection();
            Console.WriteLine(" ");
            var meat = MeatR1.Meats[selectedCandy - 1];
            if (meat is null || wallet >= meat.Price)
            {
                ShoppingCart.AddProduct(meat);
                decimal CountTotal = wallet - meat.Price;
                Console.WriteLine($"Candy with index {selectedCandy - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                Console.WriteLine(" ");
                decimal CountTotal1 = CountTotal;
                wallet = (int)CountTotal1;

            }
            else if (meat.Price > wallet)
            {
                Console.WriteLine($"Candy with index {selectedCandy - 1} is too expensive or does not exist");
                Console.WriteLine(" ");
            }
        }

        public void BuyDrinks()
        {
            PrintDrinks();
            Console.WriteLine("Choose the number of drink you want to add to the cart:");
            var selectedDrink = GetSelection();
            var drink = DrinksR1.Drinks[selectedDrink - 1];
            if (drink is null || wallet >= drink.Price)
            {
                ShoppingCart.AddProduct(drink);
                decimal CountTotal = wallet - drink.Price;
                Console.WriteLine($"Candy with index {selectedDrink - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                Console.WriteLine(" ");
                decimal CountTotal1 = CountTotal;
                wallet = (int)CountTotal1;

            }
            else if (drink.Price > wallet)
            {
                Console.WriteLine($"Candy with index {selectedDrink - 1} is too expensive or does not exist");
                Console.WriteLine(" ");
            }
        }

        public void BuyVeggies()
        {
            PrintVeggies();     
            Console.WriteLine("Choose the number of veggies you want to add to the cart:");
            var selectedVeggies = GetSelection();
            var veggies = VegetablesR1.Vegetables[selectedVeggies - 1];
            if (veggies is null || wallet >= veggies.Price)
            {
                ShoppingCart.AddProduct(veggies);
                decimal CountTotal = wallet - veggies.Price;
                Console.WriteLine($"Candy with index {selectedVeggies - 1} was added to your shopping cart");
                Console.WriteLine($"You have {CountTotal} Euros left in your wallet.");
                Console.WriteLine(" ");
                decimal CountTotal1 = CountTotal;
                wallet = (int)CountTotal1;

            }
            else if (veggies.Price > wallet)
            {
                Console.WriteLine($"Candy with index {selectedVeggies - 1} is too expensive or does not exist");
                Console.WriteLine(" ");
            }
        }

        public int GetSelection()
        {
            bool isSuccess = Int32.TryParse(Console.ReadLine(), out int result);
            if (isSuccess)
            {
                return result;
            }
            Console.WriteLine("Invalid entry");
            return 0;
        }

        public void BuyCart()
        {
            Console.WriteLine("1. Pirkti");
            Console.WriteLine("2. Atgal");
            var Selection = GetSelection();
            Console.WriteLine(" ");
            switch (Selection)
            {
                case 0:
                    break;
                case 1:
                    PrintCheque();
                    ShoppingCart.RemoveCart();
                    break;
                case 2:
                    return;
                    break;
            }
        }
        public void PrintCandies()
        {
            foreach (Candy candy in CandyR1.Candies)
            {
                Console.WriteLine(candy);
            }
            Console.WriteLine(" ");
        }

        public void PrintCheque()
        {
            Console.WriteLine("------------------------");
            ShoppingCart.PrintCart();
            Console.WriteLine("------------------------");
            ShoppingCart.PrintCost();
            Console.WriteLine("Dekui kad apsipirkinejote\nVendorMachine 3000");
            Console.WriteLine("------------------------");
            Console.WriteLine(" ");
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
    }
}
