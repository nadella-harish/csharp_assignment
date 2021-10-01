using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
	class BankAccount
	{
		double Balance;

		public BankAccount()
		{
			this.Balance = 500;
		}
		public BankAccount(double Balance)
		{
			this.Balance = Balance;
		}

		public double getbalance()
		{
			return Balance;
		}
	}

	class finalbankaccount
	{
		public static void Main()
		{

			BankAccount b1 = new BankAccount();
			BankAccount b2 = new BankAccount(50000);

			Console.WriteLine("default balance = " + b1.getbalance());
			Console.WriteLine("account balance = " + b2.getbalance());
		}

	}
}

