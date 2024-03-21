/*
Задание 2:
Для приложения объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
метод получает входным параметром переменную типа double;
метод возвращает значение типа double, которое есть результатом вычисления в соответствии с условием задачи.
Реализовать вызов трех методов с помощью делегата, которые получают радиус R в качестве входного параметра и вычисляют:
длину окружности по формуле D = 2 · π · R;
площадь круга по формуле S = π · R2;
объем шара. Формула V = 4/3 · π · R3.
Методы должны быть представлены в отдельном классе как нестатические (без ключевого слова static). Желательно, чтобы класс был объявлен в отдельном модуле (файле).
 */

namespace Delegates_Task2
{
    internal class TaskExecution
    {
        public delegate double CalculateDelegate(double r);
        static void Main()
        {
            Console.Write("Введите радиус, для которого необходим расчет: "); 
            double r = double.Parse(Console.ReadLine());

            CalculationMethods methods = new CalculationMethods();//для нестатических методов
            CalculateDelegate example = methods.Lenth;
            double resultLenth = example(r);
            CalculateDelegate example2 = methods.Area;
            double resultArea = example2(r);
            CalculateDelegate example3 = methods.Volume;
            double resultVolume = example3(r);
        }
    }   
}