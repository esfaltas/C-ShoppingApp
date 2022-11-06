using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Servicing
    {
        private string CandiesPath = "E:\\studijos\\Paskaitos\\paskaituKodai\\BE\\ShoppingApp1\\ConsoleApp1\\Data\\Candies.csv";
        private string MeatsPath = "E:\\studijos\\Paskaitos\\paskaituKodai\\BE\\ShoppingApp1\\ConsoleApp1\\Data\\Meat.csv";
        private string DrinksPath = "E:\\studijos\\Paskaitos\\paskaituKodai\\BE\\ShoppingApp1\\ConsoleApp1\\Data\\Drinks.csv";
        private string VegetablesPath = "E:\\studijos\\Paskaitos\\paskaituKodai\\BE\\ShoppingApp1\\ConsoleApp1\\Data\\Veggies.csv";

        public List<Candy> ReadCandies()
        {
            string text = File.ReadAllText(CandiesPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var candies = new List<Candy>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var candy = new Candy
                {
                    Name = productDataArray[0],
                    Price = Convert.ToDecimal(productDataArray[1]),
                    Barcode = productDataArray[2],
                    Weight = Convert.ToDouble(productDataArray[3]),
                    SugarAmountInGrams = Convert.ToDouble(productDataArray[4])
                };

                candies.Add(candy);
            }

            return candies;
        }

        public List<Meat> ReadMeats()
        {
            string text = File.ReadAllText(MeatsPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var meats = new List<Meat>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var meat = new Meat
                {
                    Name = productDataArray[0],
                    Price = Convert.ToDecimal(productDataArray[1]),
                    Barcode = productDataArray[2],
                    Weight = Convert.ToDouble(productDataArray[3]),
                    Protein = Convert.ToDouble(productDataArray[4])
                };

                meats.Add(meat);
            }

            return meats;
        }

        public List<Drinks> ReadDrinks()
        {
            string text = File.ReadAllText(DrinksPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var drinks = new List<Drinks>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var drink = new Drinks
                {
                    Name = productDataArray[0],
                    Price = Convert.ToDecimal(productDataArray[1]),
                    Barcode = productDataArray[2],
                    Weight = Convert.ToDouble(productDataArray[3]),
                    Liter = Convert.ToDouble(productDataArray[4])
                };

                drinks.Add(drink);
            }

            return drinks;
        }

        public List<Vegetables> ReadVegetables()
        {
            string text = File.ReadAllText(VegetablesPath);
            string[] lines = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var vegetables = new List<Vegetables>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] productDataArray = lines[i].Split(',');
                var vegetable = new Vegetables
                {
                    Name = productDataArray[0],
                    Price = Convert.ToDecimal(productDataArray[1]),
                    Barcode = productDataArray[2],
                    Weight = Convert.ToDouble(productDataArray[3]),
                    Fiber = Convert.ToDouble(productDataArray[4])
                };

                vegetables.Add(vegetable);
            }

            return vegetables;
        }
    }
}
