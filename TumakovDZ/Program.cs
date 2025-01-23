using System;


namespace TumakovDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task131();
            Task132();
            Task133();
            Task134();
            Console.ReadKey();
        }
        static void Task131()
        {
            Console.WriteLine("Task number 1-------------------------------------------\n");

            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount(10000);
            BankAccount bankAccount3 = new BankAccount(20000, TypeSchet.tekushiy);
            bankAccount1.PrintBankAccount();
            bankAccount2.PrintBankAccount();
            bankAccount3.PrintBankAccount();
        }
        static void Task132()
        {
            Console.WriteLine("\nTask number 2-------------------------------------------\n");

            BankAccount bankAccount = new BankAccount(1000, TypeSchet.obshiy);
            bankAccount.SnyatieSam(500);
            BankTransaction firstTransaction = bankAccount[0];
            Console.WriteLine($"Первая транзакция: {firstTransaction.Summa}, дата: {firstTransaction.Date}");
        }
        static void Task133()
        {
            Console.WriteLine("\nTask number 3-------------------------------------------\n");

            BankSchet account = new BankSchet(1000, TypeSchet.obshiy);
            account.Snyatie(500);
            Console.WriteLine("Баланс после снятия: {account.Balanceschet}");
            
        }
        static void Task134()
        {
            Console.WriteLine("\nTask number 4-------------------------------------------\n");

            BuildingCollection collection = new BuildingCollection();
            collection[0] = new Building("1", 5);
            collection[1] = new Building("2", 10);
            collection[2] = new Building("3", 3);
            collection[3] = new Building("4", 5);
            collection[4] = new Building("5", 10);
            collection[5] = new Building("6", 3);
            collection[6] = new Building("7", 5);
            collection[7] = new Building("8", 10);
            collection[8] = new Building("9", 3);
            collection[9] = new Building("10", 3);

            for (int i = 0; i < 10; i++)
            {
                if (collection[i] != null)
                {
                    Console.WriteLine(collection[i]);
                }
            }
        }
    }
}
