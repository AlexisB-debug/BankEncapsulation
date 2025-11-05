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
        if (_balance - aWithdrawal >= -50)
        {
            _balance = _balance - aWithdrawal;
        }
        else
        {
            Console.WriteLine($"Withdrawal Terminated!\nThe account overdraft privilege is -$50.00.\nThe attempted withdrawal of ${aWithdrawal} leaves a balance of -${Math.Abs(_balance - aWithdrawal)}.");
        }

    }

    public double GetBalance()
    {
        double currentBalance = _balance;
        return currentBalance;
    }
}