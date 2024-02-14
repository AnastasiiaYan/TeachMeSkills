using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Task2
{
    internal class Part : Product
    {       
        public int amount { get; set; }        
        public Part(string name, double price, int amount, DateTime createDate, DateTime expirationDate) : base(name, price, createDate, expirationDate)
        {            
            this.amount = amount;            
        }
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