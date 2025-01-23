
using System;

namespace TumakovDZ
{
    public class BankTransaction
    {
        public decimal Summa { get; }
        public DateTime Date { get; }
        public BankAccount Account { get; set; }

        public BankTransaction(decimal summa)
        {
            Summa = summa;
            Date = DateTime.Now;
        }

        public static int TransactionCount { get; set; }
    }
}
