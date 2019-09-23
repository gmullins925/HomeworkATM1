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
			int amount;
			string accountName;
			Checking checking = null;
			Savings savings = null;

			int menuOption = 0;
			

			while (menuOption != 1)
			{
				menuOption = GetNumber("1 - Exit\n2 - Create Checking\n3 - Create Savings\n4 - CHK Acct Balance\n5 - " +
					"Savings Balance\n6 - Checking Deposit\n7 - Savings Deposit\n8 - Account Transfer\n>");

				switch (menuOption)
				{

					case 1:
						break;

					case 2:
						accountName = GetInput("Account Name: ");
						balance = GetNumber("Initial Amt: ");
						checking = new Checking(accountName, balance, 0.02f);
						break;

					case 3:
						accountName = GetInput("Account Name: ");
						balance = GetNumber("Initial Amt: ");
						savings = new Savings(accountName, balance, 0.03f);
						break;

					case 4:
						accountName = GetInput("Account Name: ");
						Console.WriteLine(checking.Balance);
						break;

					case 5:
						accountName = GetInput("Account Name: ");
						Console.WriteLine(savings.Balance);
						break;

					case 6:
						accountName = GetInput("Account Name: ");
						amount = GetNumber("Deposit Amount: ");
						checking.Deposit(amount);
						break;

					case 7:
						accountName = GetInput("Account Name: ");
						amount = GetNumber("Deposit Amount: ");
						savings.Deposit(amount);
						break;

					case 8:
						int direction = GetNumber("1 - Transfer From Checking to Savings\n2 - Transfer From Savings to Checking\n>");
						amount = GetNumber("Transfer Amount: ");
						if (direction == 1)
							{
							checking.Withdrawal(amount);
							savings.Deposit(amount);
							}
						else
							{
							savings.Withdrawal(amount);
							checking.Deposit(amount);
							}
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
