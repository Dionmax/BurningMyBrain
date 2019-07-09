using Aula126_Upcasting_Downcasting.Entities;

namespace Aula126_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new BusinessAccount();
            Account acc2 = new SavingsAccount();
            Account acc3;

            acc3 = acc1 as SavingsAccount;


            if (acc2 is BusinessAccount)
                System.Console.WriteLine("Business Account");
            else
                System.Console.WriteLine("Not business Account");
        }
    }
}
