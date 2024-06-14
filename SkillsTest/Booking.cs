using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Booking
    {
        //Properties
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int Participants { get; set; }

        //bool for opgave 6
        public bool BookingDurationOK
        {
            get
            {
                return StartTime.AddHours(2) >= EndTime;
            }
        }

        public bool IsSundayBooking
        {
            get
            {
                return StartTime.DayOfWeek == DayOfWeek.Sunday;
            }
        }
        public Booking(int id, DateTime startTime, DateTime endTime, int participants)
        // Constructor
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Participants = participants;
        }

        //Methods + opgave 6
        public override string ToString()
        {
            return $"Id: {Id}, StartTime: {StartTime}, EndTime: {EndTime}, Participants: {Participants}, Duration OK: {BookingDurationOK}, Is Sunday: {IsSundayBooking}";
        }
    }
    }
