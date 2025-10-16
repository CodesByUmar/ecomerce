// using System;

// public class BankAccount
// {
//     private string accountNumber;
//     private decimal balance;

//     public BankAccount(string accountNumber, decimal initialBalance)
//     {
//         this.accountNumber = accountNumber;
//         this.balance = initialBalance;
//     }

//     public void Deposit(decimal amount)
//     {
//         if (amount > 0)
//         {
//             balance += amount;
//             Console.WriteLine($"{amount} so'm {accountNumber} raqamli hisob raqamiga qo'yildi.");
//         }
//         else
//         {
//             Console.WriteLine("Xato: miqdor musbat bo'lishi kerak.");
//         }
//     }

//     public void Withdraw(decimal amount)
//     {
//         if (amount > 0 && amount <= balance)
//         {
//             balance -= amount;
//             Console.WriteLine($"{amount} so'm {accountNumber} raqamli hisob raqamidan yechildi.");
//         }
//         else
//         {
//             Console.WriteLine("Xato: Yetarli mablag' yo'q yoki noto'g'ri miqdor.");
//         }
//     }

//     public void CheckBalance()
//     {
//         Console.WriteLine($"Hisob raqam {accountNumber} balansi: {balance} so'm");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         BankAccount acc1 = new BankAccount("dodam", 50000);
//         BankAccount acc2 = new BankAccount("ukam", 100000);

//         Console.WriteLine("\n--- 1-Hisob raqami bo'yicha operatsiyalar ---");
//         acc1.CheckBalance();
//         acc1.Deposit(20000);
//         acc1.Withdraw(0000);
//         acc1.CheckBalance();

//         Console.WriteLine("\n--- 2-Hisob raqami bo'yicha operatsiyalar ---");
//         acc2.CheckBalance();
//         acc2.Withdraw(120000);
//         acc2.Deposit(50000);
//         acc2.CheckBalance();
//     }
// }
