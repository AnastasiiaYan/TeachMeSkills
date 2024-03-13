/*
Задание 2:
Исходная последовательность содержит сведения о клиентах фитнес-центра. 
Каждый элемент последовательности включает следующие целочисленные поля: 
< Код клиента >; < Год >; < Номер месяца >; < Продолжительность занятий(в часах) >;
Найти элемент последовательности с минимальной продолжительностью занятий. 
Вывести эту продолжительность, а также соответствующие ей год и номер месяца (в указанном порядке на той же строке). 
Если имеется несколько элементов с минимальной продолжительностью, то вывести данные того из них, который является последним в исходной последовательности
*/

using LINQ_Task2;
using System.Linq;

namespace LINQ_Task2
{
    internal class TaskExecution
         
    {
        static void Main()
        {
            List<Clients> clients = new List<Clients>()
            {
                new Clients(1,2024,1,1),
                new Clients(2,2024,2,2),
                new Clients(3,2024,3,3),
                new Clients(0,2024,0,0),
            };
            
            var minDuration = clients.OrderByDescending(c => c.trainingDuration).Last();
            Console.WriteLine($"TrainingDuration: {minDuration.trainingDuration}, Year: {minDuration.year}, Month: {minDuration.month}");
        }
    }
}