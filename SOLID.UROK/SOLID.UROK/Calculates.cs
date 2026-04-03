using SOLIDItog.Model;
using SOLIDItog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDItog
{
    public class Calculator
    {
        public void Calculate(ICalculateAccount accountType, Account account)
        {
            accountType.CalculateInterest(account);
        }
    }
}
