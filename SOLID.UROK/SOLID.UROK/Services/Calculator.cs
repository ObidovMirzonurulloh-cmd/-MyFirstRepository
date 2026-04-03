using SOLIDItog.Model;
using SOLIDItog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDItog.Services
{
    public class RegularAccount : ICalculateAccount
    {
        public void CalculateInterest(Account account)
        {
            double interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                interest -= interest * 0.2; // уменьшаем 20% от 40%
            else
                interest -= interest * 0.4; // уменьшаем 40% от 40%

            account.Interest = interest;
        }
    }



    public class SalaryAccount : ICalculateAccount
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }

}