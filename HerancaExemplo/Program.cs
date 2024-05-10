using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerancaExemplo.Entities;

namespace HerancaExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Guilherme", 0.0); //Instanciar objeto do tipo Account
            BusinessAccount bacc = new BusinessAccount(1002, "Gerso", 0.0, 500.0);//Instaciar objeto do tipo BusinessAccount

            //UPCASTING (Conversão de superclasse para subclasse) - Account superclasse - SavingsAccount subclasse - BusinessAccount subclasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);

            //DONWCASTING (Conversão de subclasse para superclasse)

            BusinessAccount acc4 = (BusinessAccount)acc2; //(BusinessAccount)acc2 - Transforma Account em BusinessAccount
            acc4.Loan(100.0); //.Loan (100.0) - Empréstimo de 100 reais
          
            if (acc3 is BusinessAccount)//is - for
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; //OU BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) 
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
