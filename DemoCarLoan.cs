using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoanNew
{
    class DemoCarLoan
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan(333, "Harison", 7000.00);
            CarLoan aCarLoan = new CarLoan(250, "Carlisile", 30000.00, 2012, "Ford");

            WriteLine("The loan of {0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));
            WriteLine("The loan of {0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount.ToString("C2"));
            WriteLine("The loan of {0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
            WriteLine("Click enter to exit...");
            ReadLine();
        }
    }
}