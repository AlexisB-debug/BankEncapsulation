namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;

    public void Deposit(double aDeposit)
    {
        _balance = _balance + aDeposit;
    }

    public void Withdraw(double aWithdrawal)
    {
        _balance = _balance - aWithdrawal;
    }

    public double GetBalance()
    {
        Console.WriteLine($"Current Balance: ${_balance}");
    }
}