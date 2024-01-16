namespace MethodsAndClasses_Task2
{
    public class CreditCard
    {
        public string PersonalAccount;
        public double CurrentBalance;

        public CreditCard(string PersonalAccountNumber, double PersonalAccountBalance)
        {
            this.PersonalAccount = PersonalAccountNumber;
            this.CurrentBalance = PersonalAccountBalance;
        }

        public void putMoney(double put) 
        {
            CurrentBalance += put;
        }

        public void takeMoney(double take)
        {
            CurrentBalance -= take;
        }

        public void getInfo()
        {
            Console.WriteLine($"Лицевой счет: {PersonalAccount}, текущий баланс: {CurrentBalance}");
        }

    }
}
