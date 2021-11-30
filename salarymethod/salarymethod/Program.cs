using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarymethod
{
    class hourlyemp
    {
        int hourWorked;
        int BASE_HOURS;
        int basepay;
        int overtimePay;
        int overtimeHours;
        int HourlyPayRate;
        int OVERTIME_RATE;
        int unitpay;
        int unitProduce;
        int Grosspay;

        public void Calculate_salary()
        {
            

        }
        class monthlyemp
        {
            int hourWorked;
            int BASE_HOURS;
            int basepay;
            int overtimePay;
            int overtimeHours;
            int HourlyPayRate;
            int OVERTIME_RATE;
            int unitpay;
            int unitProduce;
            int Grosspay;

            public void Calculate_salary()
            {
                if (hourWorked > BASE_HOURS)
                {
                    basepay = HourlyPayRate * BASE_HOURS;

                    overtimeHours = hourWorked - BASE_HOURS;

                    overtimePay = overtimeHours * HourlyPayRate * OVERTIME_RATE;

                    unitpay = 3 * unitProduce;

                    Grosspay = basepay + overtimePay + unitpay;
                }

            }
            static void Main(string[] args)
            {
               
            }

        }
    }
}

