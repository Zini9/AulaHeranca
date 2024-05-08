using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo.Entities
{
    internal class BusinessAccount : Account // (: Account) Para extender a classe account à BusinessAccount
    {
        public double LoanLimite { get; set; }

        public BusinessAccount() //Vazio para ter opção de criar objeto sem passar dados
        {
        }

        public BusinessAccount (int number, string holder, double balance, double loanLimite) 
            : base(number, holder, balance) //(:base) aproveia o contrutor da classe account
        {
            LoanLimite = loanLimite;
        }

        public void Loan (double amount) 
        {
            if (amount <= LoanLimite)
            {
                Balance += amount;
            }
        }
    }
}
