/*
Задание 2:
Реализовать полную структуру классов и их взаимосвязь продумать самостоятельно. 
Исходные данные: база (массив) из n товаров задать непосредственно в коде (захардкодить);
Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить, соответствует ли она сроку годности на текущую дату;

Создать производные классы:
Продукт (название, цена, дата производства, срок годности),
Партия (название, цена, количество шт, дата производства, срок годности), 
Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.

Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск просроченного товара (на момент текущей даты).

*/

using System.Collections.Generic;

namespace Abstract_Task2;

internal class TaskExecution
{
    static void Main()
    {
        Product[] productDatabase =
        {
            new Product("Cake",250,DateTime.Now,DateTime.Now.AddDays(30)),
            new Product("Tea",99.90,DateTime.Now.AddDays(-30),DateTime.Now),
            new Product("Pie", 590, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1)),
            new Product("Coffe", 180, new DateTime(2024, 2, 1), new DateTime(2024, 2, 3)),
            new Product("Pudding", 210.90, new DateTime(2024, 1, 31), new DateTime(2024, 2, 5))
        };
                
        foreach (Product p in productDatabase)
        {
            p.PrintInfo();
            p.CheckExpiration();                      
        }

        Set setProduct = new Set("Breakfast", 500, new List<Product>()
        {
            new Product("Cake",250,DateTime.Now,DateTime.Now.AddDays(30)),
            new Product("Tea",99.90,DateTime.Now.AddDays(-30),DateTime.Now)
        });
        setProduct.PrintInfo();
        setProduct.CheckExpiration();
    }        
}