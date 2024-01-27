namespace MethodsAndClasses_Task2
{
    public class CreditCard
    {
        internal  string personalAccount;
        internal double currentBalance;

        public CreditCard(string PersonalAccountNumber, double PersonalAccountBalance)
        {
            this.personalAccount = PersonalAccountNumber;
            this.currentBalance = PersonalAccountBalance;
        }

        public void putMoney(double put) 
        {
            currentBalance += put;
        }

        public void takeMoney(double take)
        {
            currentBalance -= take;
        }

        public void getInfo()
        {
            Console.WriteLine($"Лицевой счет: {personalAccount}, текущий баланс: {currentBalance}");
        }
    }
}
