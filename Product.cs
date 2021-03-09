using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLista2App
{
    public class Product
    {
        //List<string> productList = new List<string>();

        public Product()
        {
        }

        public Product(string productCategory, string productName, double productPrice)
        {
            ProductCategory = productCategory;
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        /*public void AddProduct(string productString)
        {
            productList.Add(productString);
            //index++;
        }  */
    }
}
