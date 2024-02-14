using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_Task2
{
    internal class Set : BaseProduct
    {
        public string name { get; set; }
        public double price { get; set; }
        public List<Product> ProductList { get; set; }
        public Set(string name, double price, List<Product> ProductList)
        {
            this.name = name;
            this.ProductList = ProductList;
            this.price = price;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"\nНазвание: {name}.\nЦена: {price}.\nКомплект содержит: {ProductList}.");

            if (!CheckExpiration())
            {
                Console.WriteLine("Внимание!В комплекте есть продукты с истекшим сроком годности!");
            }
        }
        public override bool CheckExpiration()
        {
            foreach (Product p in ProductList)
            {
                if (!p.CheckExpiration()) return true;                
            }
            return false;
        }
    }
}