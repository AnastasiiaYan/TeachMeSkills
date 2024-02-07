using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Task2
{
    internal class Part : BaseProduct
    {
        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public DateTime createDate { get; set; }
        public DateTime expirationDate { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Цена: {price}");
            Console.WriteLine($"Количество шт: {amount}");
            Console.WriteLine($"Дата производства: {createDate}");
            Console.WriteLine($"Годен до: {expirationDate}");
        }
        public override bool CheckExpiration()
        {
            if (expirationDate.CompareTo(DateTime.Today) >= 0) return true;
            else return false; // можно короче: return DateTime.Now > expirationDate;
        }
    }
}
