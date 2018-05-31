using System;
namespace Payroll
{
    public class Manager : Staff
    {
        private const float managerHourlyRate = 50;

        private int Allowance { get; set; }

        public Manager(string name) : base(name, managerHourlyRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
                TotalPay = BasicPay + Allowance;
             else
                TotalPay = BasicPay;
            
        }

        public override string ToString()
        {
            return "Name of staff: " + NameOfStaff +
            ",hourlyRate: " + managerHourlyRate +
            ", hWorked: " + HoursWorked;
        }
    }
}