namespace BankEncapsulation;

public class BankAccount
{
    public BankAccount()
    {
        
    }

    private double _balance = 0.0;
    
    // The infinite do-while loop repeatedly asks the user whether he/she wants his/her current balance.
    //That is why I erased the Console.WriteLine from Deposit & Withdraw methods.

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
        double currentBalance = _balance;
        return currentBalance;
    }
}