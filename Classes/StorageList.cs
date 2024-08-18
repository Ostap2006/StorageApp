using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StorageApp1.Classes
{
    public class StorageList
    {
        public List<Product>  Products { get; set; }

        public StorageList()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            product.SetIndex(Products.Count);
        }

        public void SaveProducts(string path)
        {
            using (var writer = new StreamWriter(path, false))
            {
                foreach (var product in Products)
                {
                    writer.WriteLine("Product:");
                    writer.WriteLine($"Index: {product.Index}");
                    writer.WriteLine($"Name: {product.Name}");
                    writer.WriteLine($"Unit: {product.Unit}");
                    writer.WriteLine($"Price: {product.Price}");
                    writer.WriteLine($"Quantity: {product.Quantity}");
                    writer.WriteLine($"LastDeliveryDate: {product.LastDeliveryDate:yyyy-MM-dd}");
                    writer.WriteLine(new string('-', 20));
                }
            }
        }

        public void ReindexProducts()
        {
            int index = 1;
            foreach (var product in Products)
            {
                product.SetIndex(index);
                index++;
            }
        }

        public void LoadProducts(string path)
        {
            Products.Clear();
            using (var reader = new StreamReader(path))
            {
                string line;
                int count = 1;
                Product product = null;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Product:"))
                    {
                        if (product != null)
                        {
                            product.SetIndex(count);
                            Products.Add(product);
                            count++;
                        }

                        product = new Product();
                    }

                    else if (line.StartsWith("Name:"))
                    {
                        if (product != null)
                            product.Name = line.Substring(6);
                    }

                    else if (line.StartsWith("Unit:"))
                    {
                        if (product != null)
                            product.Unit = line.Substring(6);
                    }

                    else if (line.StartsWith("Price:"))
                    {
                        if (product != null)
                            product.Price = double.Parse(line.Substring(7));
                    }

                    else if (line.StartsWith("Quantity:"))
                    {
                        if (product != null)
                            product.Quantity = int.Parse(line.Substring(10));
                    }

                    else if (line.StartsWith("LastDeliveryDate:"))
                    {
                        if (product != null)
                            product.LastDeliveryDate = DateTime.Parse(line.Substring(18));
                    }

                    else if (line.StartsWith(new string('-', 20))) { }
                }
                if (product != null)
                {
                    product.SetIndex(count);
                    Products.Add(product);
                }
                }
        }
    }
}
