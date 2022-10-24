using ClassLibrary1;

namespace ProductDB
{
    public static class ProductData
    {
        public static List<Product> Products { get; set; }

        static ProductData() // static classlarda public ile constructor tanımlanmaz onun yerine static ile tanımlanır.
        {
            var category1 = new Category()
            {
                CategoryId = 1,
                CategoryName = "Electronic"
            };

            Product product1 = new Product();
            product1.ProductName = "Telephone";
            product1.Price = 4000;
            product1.Category = category1;

            Product product2 = new Product();
            product2.ProductName = "Laptop";
            product2.Price = 14000;
            product2.Category = category1;

            Product product3 = new Product();
            product3.ProductName = "Headphones";
            product3.Price = 1000;
            product3.Category = category1;

            Products = new List<Product>()
            {
                product1, product2, product3
            };
        }

        public static void GetAll()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"Name: {item.ProductName} - Price: {item.Price} - Category: {item.Category.CategoryName}");
            }
        }
    }
}