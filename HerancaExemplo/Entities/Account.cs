using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        
        public Account() //Construtores
        { 
        }
        public Account (int number, string holder, double balance) //Construtores com argumentos
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw (double amount) //Quantia (amount) é retirado do saque da conta (balance)
        {
            Balance = amount;
        }
        
        public void Deposit(double amount) //Pegar saldo e acrescentar a quantia
        { 
            Balance += amount;
        }
    }
}
