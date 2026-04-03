using SOLIDItog;
using SOLIDItog.Model;
using SOLIDItog.Services;
using System;

namespace Irog
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account { Balance = 2000 };
            ICalculateAccount type = new RegularAccount(); // можно менять на SalaryAccount

            var calculate = new Calculator();
            calculate.Calculate(type, account);

            Console.WriteLine(account.Interest);
        }
    }
}