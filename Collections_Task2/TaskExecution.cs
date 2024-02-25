/*
Задание 2:
Напишите программу, используя Dictionary, чтобы управлять инвентарем товаров в магазине.
Ваша программа должна предоставлять следующие функциональности:
- Добавление товара: 
Каталог товаров генерируется на основании рандомных значений или инициализируется конкретными данными. 
Информация о новом товаре, включает уникальный идентификатор, название, цену и количество на складе.
- Отображение списка товаров: 
Пользователь может просматривать список всех товаров в магазине, включая название, цену и количество на складе.
- Поиск товара по идентификатору: 
Пользователь может ввести уникальный идентификатор товара, и программа должна отобразить информацию о товаре с этим идентификатором.
- Обновление информации о товаре: 
Пользователь может выбрать товар из списка и обновить его цену или количество на складе.
- Удаление товара: 
Пользователь может выбрать товар из списка и удалить его из инвентаря.
*/

using System.Diagnostics;
using System.Xml.Linq;

namespace Collections_Task2;
public class TaskExecution
{
    static void Main()
    {
        ShopInventory shopInventory = new ShopInventory();
        shopInventory.Add("Шоколад", 190.5, 300);
        shopInventory.Add("Карамель", 12.9, 34);
        shopInventory.Add("Миндаль", 1234, 10);
        shopInventory.Add("Лимонный курд", 310, 100);

        shopInventory.ShowInventory();

        Console.WriteLine("Введите ID товара из списка, по которому необходимо вывести детальную информацию");        
        shopInventory.Find(int.Parse(Console.ReadLine()));

        Console.WriteLine("Введите ID товара из списка, по которому необходимо обновить информацию");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите цену, которую требуется задать за еденицу товара");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество данного товара");
        int amount = int.Parse(Console.ReadLine());
        shopInventory.Update(id, price, amount);

        Console.WriteLine("Введите ID товара из списка, который необходимо удалить");
        shopInventory.Remove(int.Parse(Console.ReadLine()));
    }
}