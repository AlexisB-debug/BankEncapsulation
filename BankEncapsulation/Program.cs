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
                    alexis.GetBalance();
                }
                else //(banking == "goodbye")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                Console.WriteLine("Return to the main menu to continue banking?\nPlease, type 'yes' or 'no'.");
                string repeat = Console.ReadLine().ToLower();
                mercantile = repeat == "yes";
            }while(mercantile);

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
