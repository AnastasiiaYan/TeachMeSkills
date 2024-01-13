/* Задание 2
Создать класс CreditCard c полями 
номер счета, 
текущая сумма на счету.

Добавьте методы: 
который позволяет зачислять сумму на кредитную карту;
который позволяет снимать некоторую сумму с карты;
который выводит текущую информацию о карточке.

Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма.

Тестовый сценарий для проверки:
Положите деньги на первые две карточки и снимите с третьей.
Выведите на экран текущее состояние всех трех карточек.

﻿/* Задание 1:
Создайте класс Phone, который содержит переменные number, model и weight.

Добавить конструкторы в класс Phone: 
конструктор без параметров.
принимает на вход два параметра для инициализации переменных класса - number, model.
принимает на вход три параметра для инициализации всех переменных класса Phone. 
Вызвать из этого конструктора конструктор с двумя параметрами.

Добавить в класс Phone методы: 
1. receiveCall, с одним параметром “имя звонящего”. 
Этот метод выводит на консоль сообщение “Звонит {name}”. 
2. getNumber 
Этот метод возвращает номер телефона.
3. sendMessage с аргументами переменной длины.  
Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов 

Создайте три экземпляра этого класса используя разные конструкторы.
Выведите на консоль значения их переменных.
Вызвать методы receiveCall и getNumber для каждого из объектов.
Вызвать метод sendMessage с 2-мя и 5-ю номерами телефонов.
*/


using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MethodAndClasses 
{ 
    class Homework_2
    {        
        class CreditCard
        {
            public string persAccoutntNumber;
            public double balance;

            public void AddMoney ()
            {

            }

            
                
          
    class Homework_1
    {
        static void Main()
        {
            Phone phone1 = new Phone();
            Phone phone2 = new Phone("79160326303", "iPhone");
            Phone phone3 = new Phone("79160324219", "Huawei", 6);

            Console.WriteLine($"Телефон 1: {phone1.number}, {phone1.model}, {phone1.weight}");
            Console.WriteLine($"Телефон 2: {phone2.number}, {phone2.model}");
            Console.WriteLine($"Телефон 3: {phone3.number}, {phone3.model}, {phone3.weight}");

            phone1.receiveCall("Подружка");
            phone1.getNumber();

            phone2.receiveCall("Дядя");
            phone2.getNumber();

            phone3.receiveCall("Спам");
            phone3.getNumber();

            phone1.sendMessage("111", "222");
            phone2.sendMessage("333", "444", "555", "666", "777");
        }
    }
}
    //В C# можно создавать несколько классов в одном файле, классы должны быть частью одного пространства имен.

    class Phone
    {
    public string number;
    public string model;
    public int weight;

    //private - инкапсуляция, если делать public, я могу в main обратиться без гетера

    //констуркторы  по имени класса, всегда public
    public Phone() { }

        public Phone(string numberConstructor, string modelConstructor) 
        {
            this.number = numberConstructor;
            this.model = modelConstructor;        
        }
        
        public Phone(string numberConstructor, string modelConstructor, int weightConstructor) : this(numberConstructor, modelConstructor)
        {   
            this.weight = weightConstructor;
        }
        
        public void receiveCall(string callingName) //void - ничего не вернул, просто вывел в консоль
        {
            Console.WriteLine($"Звонит {callingName}");
        }
        public string getNumber()
        {
            return number;
        }

        public void sendMessage(params string[] phoneNumbers)// params - ключевое слово для аргумента переменной длины
        {
            Console.WriteLine("Отправляем сообщение на следующие номера:");
            foreach (string sendNum in phoneNumbers)
            {
                Console.WriteLine(sendNum);
            }
        }
    }