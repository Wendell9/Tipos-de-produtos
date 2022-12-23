using Ex_Herança.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nproducts;
            char type;
            string name;
            double price, customfee;
            DateTime manufacturedate;


            Console.Write("Enter the number of products: ");
            nproducts = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i = 0; i < nproducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                type = Console.ReadLine()[0];

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        customfee = double.Parse(Console.ReadLine());
                        ImportedProduct productI = new ImportedProduct(name, price, customfee);
                        products.Add(productI);
                        break;
                    case 'u':
                        Console.Write("Manufacture date: ");
                        manufacturedate = DateTime.Parse(Console.ReadLine());
                        UsedProduct produtoU = new UsedProduct(name, price, manufacturedate);
                        products.Add(produtoU);
                        break;
                    case 'c':
                        Product produto = new Product(name, price);
                        products.Add(produto);
                        break;

                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
