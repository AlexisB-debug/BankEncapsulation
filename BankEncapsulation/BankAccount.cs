namespace BankEncapsulation;

public class BankAccount
{
    public BankAccount()
    {
        
    }

    private double _balance = 0.0;

    public void Deposit(double aDeposit)
    {
        _balance = _balance + aDeposit;
    }

    public void Withdraw(double aWithdrawal)
    {
        _balance = _balance - aWithdrawal;
    }

    public void GetBalance()
    {
        Console.WriteLine($"Current Balance: ${_balance}");
    }
}