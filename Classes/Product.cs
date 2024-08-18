using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StorageApp1.Classes
{
    public class Product
    {
        public int Index { get; private set; }

        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public Product(string name, string unit, double price, int count, DateTime lastDeliveryDate)
        {
            Index = -1;
            Name = name;
            Unit = unit;
            Quantity = count;
            Price = price;
            LastDeliveryDate = lastDeliveryDate;
        }

        public Product() { }

        public override string ToString()
        {
            return $"{Index}. {Name}, {Quantity} {Unit}, {Price.ToString("F2")} грн, Ост. завезення: {LastDeliveryDate.ToShortDateString()}";
        }

        public void SetIndex(int index)
        {
            Index = index;
        }
    }
}
