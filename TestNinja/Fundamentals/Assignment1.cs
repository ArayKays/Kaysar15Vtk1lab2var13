using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="worktype">Кол-во дней работы(5 или 6)</param>
    /// <param name="day">Имя дня работы(полное имя на англ.)</param>
    /// <returns></returns>
        public string WorkDay(int worktype, string day)
        {
            if (worktype == 5)
            {
                string[] WorkDays = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday" };
                string[] DayOff = new string[] { "saturday", "sunday" };
                for (int i = 0; i <= worktype; i++)
                {
                    if (day.ToLower() == WorkDays[i])
                    {
                        return "Work";
                    }
                    else if (day.ToLower() == DayOff[i])
                    {
                        return "Day off";
                    }
                    else
                    {
                        return "Day inncorect";
                    }
                }
            }
            if (worktype == 6)
            {
                string[] WorkDays = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday" , "saturday" };
                string[] DayOff = new string[] { "sunday" };
                for (int i = 0; i <= worktype; i++)
                {
                    if (day.ToLower() == WorkDays[i])
                    {
                        return "Work";
                    }
                    else if (day.ToLower() == DayOff[i])
                    {
                        return "Day off";
                    }
                    else
                    {
                        return "Day inncorect";
                    }
                }
            }
            return "Error!";
        }
    }
}
