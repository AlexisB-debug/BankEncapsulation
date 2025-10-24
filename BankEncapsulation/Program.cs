namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automated Teller Machine");
            string banking = BankingDoWhileLoop();
            
            if (banking == "deposit")
            {
                // Deposit();
            }
            else if (banking == "withdrawal")
            {
                // Withdraw();
            }
            else if (banking == "current balance")
            {
                // GetBanance();
            }
            else //(banking == "goodbye")
            {
                Console.WriteLine("Goodbye");
            }

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
        }
    }
}
