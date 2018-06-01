using System;
namespace Payroll
{
    public class Payslip
    {
        private int month;
        private int year;

        enum MonthsOfYear
        {
            January, February, March, April, May, June, July, August,
            September, October, November, December
        }

        public Payslip(int payMonth, int payYear)
        {
            private month = payMonth;
            private year = payYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;

            foreach (Staff f in myStaff)
            {
                path = f.NameOfStaff + staff.txt;

                using (StreamReader sw = new StreamReader(path))
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", // Line 1 of payslip
                    (MonthsOfYear)month, year);

                    sw.WriteLine("==================="); // Line 2

                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff); // Line 3

                    sw.WriteLine("Hours Worked: {0}", hWorked); // Line 4

                    sw.WriteLine(""); // Line 5

                    sw.WriteLine("Basic Pay: {0}", C.basicPay); // Line 6

                    
                }
            }
        }
    }
}
