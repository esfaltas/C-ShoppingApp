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
                    Id = productDataArray[0],
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    SugarAmountInGrams = Convert.ToDouble(productDataArray[5])
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
                    Id = productDataArray[0],
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    Protein = Convert.ToDouble(productDataArray[5])
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
                    Id = productDataArray[0],
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    Liter = Convert.ToDouble(productDataArray[5])
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
                    Id = productDataArray[0],
                    Name = productDataArray[1],
                    Price = Convert.ToDecimal(productDataArray[2]),
                    Barcode = productDataArray[3],
                    Weight = Convert.ToDouble(productDataArray[4]),
                    Fiber = Convert.ToDouble(productDataArray[5])
                };
                vegetables.Add(vegetable);
            }
            return vegetables;
        }
    }
}
