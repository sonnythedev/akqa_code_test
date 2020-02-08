using System;
namespace PatientScheduleBackend.Models
{
    public class Schedule
    {
        public Schedule()
        {
        }
        public int providerId { get; set; }
        public string[] availabilities { get; set; }
        
    }
}
