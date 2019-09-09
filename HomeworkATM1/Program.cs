using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkATM1
{
	class Program
	{
		static void Main(string[] args)
		{
			int balance;
			string accountName;
			int menuOption = 0;
			Checking checking = null;
			Savings savings = null;

			while (menuOption != 1)
			{
				menuOption = GetNumber("1 - Exit\n2 - Create Checking\n3 - Create Savings\n4 - Account Balance");
				switch (menuOption)
				{

					case 1:
						break;

					case 2:
						accountName = GetInput("Account Name");
						balance = GetNumber("Initial Amt: ");
						checking = new Checking(accountName, balance, 0.02f);
						break;

					case 3:
						accountName = GetInput("Account Name");
						balance = GetNumber("Initial Amt: ");
						savings = new Savings(accountName, balance, 0.02f);
						break;

					case 4:
						accountName = GetInput("Account Name");
						Console.WriteLine(prompt.Balance);
						break;

					default:
						break;
				}
			}
		}   

		public static string GetInput(string prompt)
		{
			Console.Write(prompt);
			string str = Console.ReadLine();
			return str;
		}  

		public static int GetNumber(string prompt)
		{
			int userNumber;
			string strNumber = GetInput(prompt);
			while (!Int32.TryParse(strNumber, out userNumber))
			{
				Console.WriteLine("That is not an integer");
				strNumber = GetInput(prompt);
			}
			return userNumber;
		}  
	}
}
