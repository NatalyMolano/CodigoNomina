using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    public class Nomina
    {
        private int WorkDays;
        private double Health;
        private double Pension;
        private double Total_income;


        public int WorkDays1 { get => WorkDays; set => WorkDays = value; }
        public double Total_income1 { get => Total_income; set => Total_income = value; }

        public double Total(double salary)
        {
            
            Employee myemployee = new Employee();
            if (myemployee.Salary1 <= 2_000_000)
            {
                Total_income1 = myemployee.Salary1 + 117_172;
            }
            else
            {
                Total_income1 = myemployee.Salary1;
            }
            return Total_income1;
        }

        public double CalculatePayroll(int WorkDays1, double day_value )
        { 
            double totalSalirio = WorkDays1 * day_value / 30;

            return totalSalirio;
        }
        
        public double Salud(int WorkDays1, double day_value)
        {
            double TotalDevengo = WorkDays1 * day_value / 30;
            double TotalSalud = TotalDevengo * 0.04;
            return TotalSalud;
        }
        public double Pension1(int WorkDays1, double day_value)
        {
            double TotalDevengo = WorkDays1 * day_value / 30;
            double TotalPension = TotalDevengo * 0.04;
            return TotalPension;
        }

    }
}
