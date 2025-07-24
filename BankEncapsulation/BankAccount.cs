namespace BankEncapsulation;

public class BankAccount
{
    private double balance = 0;

    public void Deposit(Double amount)
    {
        balance += amount;
    }
    
    public double GetBalance()
    {
        return balance;
    }
}