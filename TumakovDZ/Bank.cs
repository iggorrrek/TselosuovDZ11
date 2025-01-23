using System;

namespace TumakovDZ
{
    public class BankSchet
    {
        private static int idCounter = 1;
        public int Id { get; }
        public decimal Balanceschet { get; set; }
        public TypeSchet Typeschet { get; set; }

        public BankSchet(decimal initialbalance, TypeSchet typeSchet)
        {
            Balanceschet = initialbalance;
            Typeschet = typeSchet;
            Id = NovuyID();
        }

        public void Snyatie(decimal value)
        {
            Balanceschet -= value;
        }

        public void Popolneniy(decimal value)
        {
            Balanceschet += value;
        }

        private static int NovuyID()
        {
            return idCounter++;
        }

        public void PrintBankSchet3()
        {
            Console.WriteLine("\nНомер счета: {Id}");
            Console.WriteLine("Баланс: {Balanceschet}");
            Console.WriteLine("Тип счета: {Typeschet}\n");
        }

        public bool Perevod(BankSchet toAccount, decimal summa)
        {
            if (summa > Balanceschet)
            {
                Console.WriteLine("Недостаточно средств.");
                return false;
            }
            Snyatie(summa);
            toAccount.Popolneniy(summa);
            return true;
        }
    }
}