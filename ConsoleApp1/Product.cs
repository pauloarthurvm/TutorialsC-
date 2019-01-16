using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public int TotalQuantity { get; set; }

        public Product(string name, double price, int totalQuantity) {
            Name = name;
            Price = price;
            TotalQuantity = totalQuantity;
        }

        public double totalValueInStock() {
            return (Price * TotalQuantity);
        }

        public void addProduct(int quantity) {
            TotalQuantity += quantity;
        }

        public void removeProduct(int quantity) {
            if(quantity <= TotalQuantity) {
                TotalQuantity -= quantity;
            } else {
                Console.WriteLine("You do not have enough products in your stock.");
                Console.WriteLine("Can only remove " + TotalQuantity + ".");
            }
        }

        public override string ToString() {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + TotalQuantity.ToString() + " units, " +
                "total value in stock: $" + totalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
