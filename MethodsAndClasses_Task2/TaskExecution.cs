/*
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
*/
namespace MethodsAndClasses_Task2
{
    public class TaskExecution
    {
        public static void Main()
        {
            CreditCard[] cards = new CreditCard[]
           {
            new CreditCard("ЛС1",100),
            new CreditCard("ЛС2",200),
            new CreditCard("ЛС3",300)
           };

            Console.WriteLine($"Введите сумму, необходимую зачислить на {cards[0].PersonalAccount}");
            cards[0].putMoney(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Введите сумму, необходимую зачислить на {cards[1].PersonalAccount}");
            cards[1].putMoney(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Введите сумму, которую требуется снять с {cards[2].PersonalAccount}");
            cards[2].takeMoney(Convert.ToDouble(Console.ReadLine()));
                        
            foreach (CreditCard card in cards)
            {
                card.getInfo(); 
            }
        }
    }
}
