using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_Task2
{
    internal class Product : BaseProduct
    {
        public string name { get; set; }
        public double price { get; set; }
        public DateTime createDate { get; set; }
        public DateTime expirationDate { get; set; }

        public Product(string name, double price, DateTime createDate, DateTime expirationDate)
        {
            this.name = name;
            this.price = price;
            this.createDate = createDate;
            this.expirationDate = expirationDate;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nНазвание: {name}.\nЦена: {price}.\nДата изготовления: {createDate}.\nГоден до: {expirationDate}");
            if (!CheckExpiration())
            {
                Console.WriteLine("Внимание!Срок годности данного товара истек!");
            }
        }
        public override bool CheckExpiration()
        {
            if (expirationDate.CompareTo(DateTime.Today) >= 0) return true;
            else return false; // можно короче: return DateTime.Now > expirationDate;
        }
    }
}