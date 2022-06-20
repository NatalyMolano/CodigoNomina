using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    public class Clslista
    {
        private double Document;
        private string FirstName;
        private string LastName;
        private double Salary;
        private double WorkDays;
        private double Health;
        private double Pension;
        private double Devengo;
        private double Total_income;

        public double Total(double salary)
        {

            Employee myemployee = new Employee();
            if (salary <= 2_000_000)
            {
                Total_income1 = salary + 117_172;
            }
            else
            {
                Total_income1 = salary;
            }
            return Total_income1;
        }

        public double CalculatePayroll(int WorkDays1, double day_value)
        {
            Devengo1 = WorkDays1 * day_value / 30;

            return Devengo1;
        }

        public double Salud(int WorkDays1, double day_value)
        {
            double TotalDevengo = WorkDays1 * day_value / 30;
            Health1= TotalDevengo * 0.04;
            return Health1;
        }
        public double pension(int WorkDays1, double day_value)
        {
            double TotalDevengo = WorkDays1 * day_value / 30;
            Pension1 = TotalDevengo * 0.04;
            return Pension1;
        }

        public double Document1 { get => Document; set => Document = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkDays1 { get => WorkDays; set => WorkDays = value; }
        public double Total_income1 { get => Total_income; set => Total_income = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        
        public double Devengo1 { get => Devengo; set => Devengo = value; }
    }
}
