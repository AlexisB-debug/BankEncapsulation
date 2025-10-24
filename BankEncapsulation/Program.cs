namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount alexis = new BankAccount();
            Console.WriteLine("Automated Teller Machine");
            
            // I created this do-while loop to store multiple deposits and withdrawals
            // So that when the user types current balance, the program will return running total
            //I purposed this loop to iterate until the user completes his/her transaction(s)
            //"goodbye" will break the infinite loop, allowing the user to decide when the loop stops iterating

            bool mercantile = true;
            do{
                string banking = BankingDoWhileLoop();
                if (banking == "deposit")
                {
                    double deposit = FigureTryParseDoWhileLoop();
                    alexis.Deposit(deposit);
                }
                else if (banking == "withdrawal")
                {
                    double withdrawal = FigureTryParseDoWhileLoop();
                    alexis.Withdraw(withdrawal);
                }
                else if (banking == "current balance")
                {
                    //The README file reads "define a method named GetBalance that will return the amount stored in the balance field"
                    //That is why I didn't create a void return type method that prints the current balance to the console.
                    double currentBalance = alexis.GetBalance();
                    Console.WriteLine($"Current Balance: {currentBalance} USD");
                }
                else //(banking == "goodbye")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }while(true);

            static string BankingDoWhileLoop()
            {
                {
                    string banking;
                    string deposit = "deposit";
                    string withdrawal = "withdrawal";
                    string currentBalance = "current balance";
                    string goodbye = "goodbye";
                    
                    do
                    {
                        Console.WriteLine("Please, type the word 'deposit', 'withdrawal', 'current balance', or 'goodbye'!");
                        banking = Console.ReadLine().ToLower();
                    }while(banking != "deposit" && banking != "withdrawal" && banking != "current balance" && banking != "goodbye");

                    return banking;
                }
            }

            static double FigureTryParseDoWhileLoop()
            {
                bool cashIsAFigure;
                double cash;
            
                do
                {
                    Console.WriteLine("Please, type a figure:");
                    cashIsAFigure = double.TryParse(Console.ReadLine(), out cash);
                }while(!cashIsAFigure);

                return cash;
            }
        }
    }
}
