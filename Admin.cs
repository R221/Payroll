using System;
namespace Payroll
{
    public class Admin : Staff
    {
        private float const overtimeRate = 15.5;
        private float const adminHourlyRate = 30;

        private float Overtime { get;set; }

        public Admin(string name) : base(name, adminHourlyRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            TotalPay = BasicPay;
            Overtime = overtimeRate * (HoursWorked - 160);

            if (HoursWorked > 160)
            {
                TotalPay = BasicPay + Overtime;
            }
            else
            {
                TotalPay = BasicPay;
            }   
        }

        public override string ToString()
        {
            return "Name of staff: " + NameOfStaff +
            ",hourlyRate: " + hourlyRate +
            ",hWorked: " + hWorked;
        } 
    }
}
