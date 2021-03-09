using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductLista2App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Validate validate = new Validate();
            List<Product> products = new List<Product>();
            Console.WriteLine("Lägg din produktdata till. Avsluta med att skriva 'q'");

            string productCategory;
            string productName;
            double productPrice;

            while (true)
            {
                Console.WriteLine("Kategori: ");
                productCategory = Console.ReadLine();
                if (productCategory.ToLower().Trim() == "q")
                {
                    Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
                    break;
                }

                //validate.CheckForExit(productCategory);
                //validate.CheckForNullOrSpace(productCategory);

                Console.WriteLine("Produkt Namn: ");
                productName = Console.ReadLine();
                if (productName.ToLower().Trim() == "q")
                {
                    Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
                    break;
                }
                //validate.CheckForExit(productName);
                //validate.CheckForNullOrSpace(productName);

                Console.WriteLine("Pris: ");
                productPrice = Convert.ToDouble(Console.ReadLine());
                if (productPrice.ToString().ToLower().Trim() == "q")
                {
                    Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
                    break;
                }
                products.Add(new Product(productCategory, productName, productPrice));
            }

            Console.WriteLine("My Products");
            Console.WriteLine("Products, sorted by Price: Low Price to High");
            products = products.OrderBy(product => product.ProductPrice).ToList();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Category".PadRight(15) + "Product Name".PadRight(15) + "Price".ToString().PadRight(15));
            Console.ResetColor();
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductCategory.PadRight(15) + product.ProductName.PadRight(15) + product.ProductPrice.ToString().PadRight(15));
            }

            double sumOfPrice = products.Sum(product => product.ProductPrice);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Total".PadRight(15) + "".PadRight(15) + sumOfPrice.ToString().PadRight(15));
            Console.ResetColor();

            Console.ReadLine();

        }
        //public static void Main(string[] args)
        //{
        //    Validate validate = new Validate();
        //    List<Product> products = new List<Product>();
        //    Console.WriteLine("Lägg din produktdata till. Avsluta med att skriva 'q'");

        //    string productCategory;
        //    string productName;
        //    double productPrice;

        //    while (true)
        //    {
        //        Console.WriteLine("Kategori: ");
        //        productCategory = Console.ReadLine();
        //        if (productCategory.ToLower().Trim() == "q")
        //        {
        //            Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
        //            Console.ResetColor();
        //            break;
        //        }

        //        validate.CheckForExit(productCategory);
        //        validate.CheckForNullOrSpace(productCategory);

        //        Console.WriteLine("Produkt Namn: ");
        //        productName = Console.ReadLine();
        //        if (productName.ToLower().Trim() == "q")
        //        {
        //            Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
        //            break;
        //        }
        //        validate.CheckForExit(productName);
        //        validate.CheckForNullOrSpace(productName);

        //        Console.WriteLine("Pris: ");
        //        productPrice = Convert.ToDouble(Console.ReadLine());
        //        if (productPrice.ToString().ToLower().Trim() == "q")
        //        {
        //            Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
        //            break;
        //        }
        //        products.Add(new Product(productCategory, productName, productPrice));
        //    }

        //    Console.WriteLine("My Products");
        //    Console.WriteLine("Products, sorted by Price: Low to High");
        //    products = products.OrderBy(product => product.ProductPrice).ToList();
        //    Console.WriteLine("Category".PadRight(15) + "Product Name".PadRight(15) + "Price".ToString().PadRight(15));
        //    foreach (Product product in products)
        //    {
        //        Console.WriteLine(product.ProductCategory.PadRight(15) + product.ProductName.PadRight(15) + product.ProductPrice.ToString().PadRight(15));
        //    }
        //    double sumOfPrice = products.Sum(product => product.ProductPrice);
        //    Console.WriteLine("Total".PadRight(15) + "".PadRight(15) + sumOfPrice.ToString().PadRight(15));

        //    Console.ReadLine();

        //}
    }

}
