using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkATM1
{
	class Savings : Account
	{
		public Savings(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
		{
			//      gift of a $100 for opening an new account
			this.Deposit(100);
		}
	}
}
