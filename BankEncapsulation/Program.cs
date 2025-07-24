namespace BankEncapsulation
{
    public class Program
    {
        static BankAccount account = new BankAccount();
        static void Main(string[] args)
        {
            Console.WriteLine("How much money do you want to deposit?");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine($"Your new balance is {account.GetBalance()}");
        }
    }
}
