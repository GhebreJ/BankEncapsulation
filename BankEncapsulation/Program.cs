namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, enter in the amount of money you wish to deposit: ");
            double amount;
            bool parsed = double.TryParse(Console.ReadLine(), out amount);

            while(!parsed)
            {
                Console.Write("Please enter a valid amount: ");
                parsed = double.TryParse(Console.ReadLine(), out amount);
            }

            var bankAcc = new BankAccount();

            bankAcc.Deposit(amount);

            Console.WriteLine($"You have {bankAcc.GetBalance()}$ in your account");

        }
    }
}
