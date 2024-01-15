namespace MethodsAndClasses_Task1
{
    public class Phone
    {
        public string number;
        public string model;
        public int weight;

        //private - инкапсуляция, но если делать public, я могу в main обратиться без гетера
        //констуркторы  по имени класса, всегда public

        public Phone() { }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(string number, string model, int weight) : this(number, model) // ключевое слово this позволяет обратиться к существующему конструктору
        {
            this.weight = weight;
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
}
