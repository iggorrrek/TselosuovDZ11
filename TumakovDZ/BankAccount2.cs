using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDZ
{
    //public class BankAccount
    //{
    //    private static int idCounter = 1;
    //    public int Id { get; }
    //    public decimal Balanceschet { get; set; }
    //    public TypeSchet Typeschet { get; }
    //    public string Holder { get; set; }

    //    private List<BankTransaction> transactions = new List<BankTransaction>();

    //    public BankTransaction this[int index]
    //    {
    //        get
    //        {
    //            return transactions[index];
    //        }
    //    }

    //    public BankAccount()
    //    {
    //        Balanceschet = 0;
    //        Typeschet = TypeSchet.Obshiy;
    //        Id = NovuyID();
    //    }

    //    public BankAccount(decimal a)
    //    {
    //        Balanceschet = a;
    //        Typeschet = TypeSchet.Obshiy;
    //        Id = NovuyID();
    //    }

    //    public BankTransaction AddTransaction(BankTransaction transaction)
    //    {
    //        transaction.Account = this;
    //        transactions.Add(transaction);
    //        return transaction;
    //    }

    //    private void Snyatie(decimal value)
    //    {
    //        Balanceschet -= value;
    //    }

    //    public void SnyatieSam(decimal value)
    //    {
    //        if (Balanceschet >= value)
    //        {
    //            Snyatie(value);
    //            AddTransaction(new BankTransaction(-value));
    //        }
    //        else
    //        {
    //            Console.WriteLine("Вы не можете снять, вам не хватает денег на счету...");
    //        }
    //    }

    //    private void Popolneniy(decimal value)
    //    {
    //        Balanceschet += value;
    //    }

    //    public void PopolneniySam(decimal value)
    //    {
    //        Popolneniy(value);
    //        AddTransaction(new BankTransaction(value));
    //    }

    //    public bool Perevod(BankAccount toAccount, decimal summa)
    //    {
    //        if (summa <= Balanceschet)
    //        {
    //            Snyatie(summa);
    //            toAccount.Popolneniy(summa);
    //            return true;
    //        }
    //        Console.WriteLine("Недостаточно средств.");
    //        return false;
    //    }

    //    public void PrintBankAccount()
    //    {
    //        Console.WriteLine($"\nНомер счета: {Id}");
    //        Console.WriteLine($"Баланс: {Balanceschet}");
    //        Console.WriteLine($"Тип счета: {Typeschet}");
    //        Console.WriteLine($"Держатель счета: {Holder}");
    //    }

    //    private static int NovuyID()
    //    {
    //        return idCounter++;
    //    }
    //}
}
