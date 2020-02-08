using System;
using System.Collections.Generic;
using PatientScheduleBackend.Models;
namespace PatientScheduleBackend.Services
{
    public class GenerateSchedule
    {
        public GenerateSchedule()
        {
        }

        public static DateTime generateRandomDate()
        {
            Random random = new Random();
            int range = 365; //1 year
            DateTime randomDate = DateTime.Today.AddDays(random.Next(range));

            return randomDate;

        }


        public static Schedule generateSchedule(int providerId)
        {
            Schedule schedule = new Schedule();
            schedule.providerId = providerId;

            string[] dates = new string[30];
            //generate 30 random availabilites date
            for (int i = 0; i < 30; i++)
            {
                dates[i] = generateRandomDate().ToString();
                

            }
            schedule.availabilities = dates;

            return schedule;

        }

    }
}



