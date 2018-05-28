using System;
namespace Payroll
{
    public class Staff
    {
        private float hourlyRate;
        private int hWorked;


        float TotalPay { get; set}
        float BasicPay { get; set}
        string NameOfStaff { get; set}
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (HoursWorked > 0)
                    return value;

                else
                    hWorked = 0;
            }
        }

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        public virtual CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "Name of staff: " + NameOfStaff + 
                ",hourlyRate: " + hourlyRate + 
                ", hWorked: " + hWorked;
        }
    }
}