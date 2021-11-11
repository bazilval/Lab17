using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс для моделирования счета в банке. 
 * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
 * Класс должен быть объявлен как обобщенный. 
 * Универсальный параметр T должен определять тип номера счета. 
 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
 * Создать  несколько экземпляров класса, параметризированного различными типам. 
 * Заполнить его поля и вывести информацию об экземпляре класса на печать.*/
namespace Lab17
{
    class BankAccount<T>
    {
        private T accountNum;
        private string holderName;
        private double accountBalance;

        public T AccountNum
        {
            set
            {
                accountNum = value;
            }
            get
            {
                return accountNum;
            }
        }
        public string HolderName
        {
            set
            {
                holderName = value;
            }
            get
            {
                return holderName;
            }
        }
        public double AccountBalance
        {
            set
            {
                if (value>=0)
                {
                    accountBalance = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным.");
                    accountBalance = 0;
                }
                
            }
            get
            {
                return accountBalance;
            }
        }
        public void AccountInfo()
        {
            Console.WriteLine($"ФИО держателя: {HolderName}");
            Console.WriteLine($"Номер счёта: {AccountNum}");
            Console.WriteLine($"Текущий баланс: {AccountBalance} руб.");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> acc1 = new BankAccount<int>();
            acc1.HolderName = "Чапаев Василий Иванович";
            acc1.AccountNum = 256;
            acc1.AccountBalance = 650839.89;
            BankAccount<byte> acc2 = new BankAccount<byte>();
            acc2.HolderName = "Исаев Петька";
            acc2.AccountNum = 255;
            acc2.AccountBalance = 0.11;
            BankAccount<string> acc3 = new BankAccount<string>();
            acc3.HolderName = "Исаева Анна";
            acc3.AccountNum = "035";
            acc3.AccountBalance = 50000.08;

            acc1.AccountInfo();
            Console.WriteLine();
            acc2.AccountInfo();
            Console.WriteLine();
            acc3.AccountInfo();

            Console.ReadKey();
        }
    }
    
}
