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
            Console.WriteLine($"\nНазвание: {name}.\nЦена: {price}.\nКоличество шт: {amount}\nДата изготовления: {createDate}.\nГоден до: {expirationDate}");
            if (!CheckExpiration())
            {
                Console.WriteLine("Внимание!Срок годности партии данного товара истек!");
            }            
        }
        public override bool CheckExpiration()
        {
            if (expirationDate.CompareTo(DateTime.Today) >= 0) return true;
            else return false; // можно короче: return DateTime.Now > expirationDate;
        }
    }
}