﻿namespace Nonstatic_Empwage
{
    public class RefactorCode
    {
        public void Cal_Wage(int maxiDays, int maxiHours)
        {
            Console.WriteLine("Program for Calculating Employee Wage !!");

            int workingHours;
            int Employeee = 1;
            int emphours = 0;
            int days = 1;
            int maxdays = maxiDays;
            int maxhours = maxiHours;
           

            while ((emphours <= maxhours) && (days <= maxdays))
            {
                int atten = CheckAttendence.checkR(Employeee);

                if (atten == 1)
                {
                    workingHours = 8;
                }
                else if (atten == 2)
                {
                    workingHours = 4;
                }
                else
                {
                    workingHours = 0;
                }
                emphours += workingHours;
                if (emphours <= maxhours)
                    Console.WriteLine("day::{0} employee_hour::{1}", days, emphours);
                days++;
            }
        }
    }
}