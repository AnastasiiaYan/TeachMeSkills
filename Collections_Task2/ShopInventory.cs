using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections_Task2
{
    internal  class ShopInventory
    {
        Dictionary<int, Product> shopInventory = new Dictionary<int, Product>();

        public void Add(string name, double price, int amount)
        {
            Random random = new Random();
            int randomId = random.Next();
            shopInventory.Add(randomId, new Product(name, price, amount));
        }
        public void ShowInventory()
        {
            foreach (KeyValuePair<int, Product> item in shopInventory) //KeyValuePair<,> - структура данных, являющаяся парой ключ-значение
            {
                Console.WriteLine($"ID: {item.Key}, Название: {item.Value.name}, Цена: {item.Value.price}, Количество: {item.Value.amount}");
            }
        }
        public void Find(int id) 
        {
            Console.WriteLine($"Название: {shopInventory[id].name}, Цена: {shopInventory[id].price}, Количество: {shopInventory[id].amount}");
        }
        public void Update(int id, double price, int amount)
        {          
            shopInventory[id].price = price;
            shopInventory[id].amount = amount;
            Console.WriteLine($"Информация о товаре обновлена.ID: {id}, Цена: {price}, Количество: {amount}");
        }
        public void Remove(int id) 
        {  
            shopInventory.Remove(id); 
        }
    }
}
