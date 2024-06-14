using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Dictionary<int, Booking> Bookings { get; set; }



        public GymHall(int id, string name, string address, string phone, string email)
        {

            // Constructor
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Bookings = new Dictionary<int, Booking>();
        }

        //Methods
        public void AddBooking(Booking booking)
        {
            Bookings.Add(booking.Id, booking);
        }

        public void RegisterBooking(Booking booking)
        {
            if (Bookings.ContainsKey(booking.Id))
            {
                
                Console.WriteLine("Booking findes allerede");
                
            }
            else
            {
                Bookings.Add(booking.Id, booking);
                Console.WriteLine("Booking tilføjet");
            }

        }

        public void PrintBookings()
        {
            foreach (var booking in Bookings)
            {
                Console.WriteLine(booking);
            }
        }

        public void RemoveBooking(int id)
        {
            if (Bookings.ContainsKey(id))
            {
                Bookings.Remove(id);
                Console.WriteLine("Booking fjernet");
            }
            else
            {
                Console.WriteLine("Booking findes ikke");
            }
            
        }

        //Opgave 7 og 8
        public bool Validate()
        {
            string message = "";

            foreach (var booking in Bookings.Values)
            {
                if (!booking.BookingDurationOK)
                {
                    //Console.WriteLine($"Din booking har kun en varighed på 2 timer");
                    //return false;
                    message = "Din booking har kun en varighed på 2 timer";
                    throw new Exception(message);

                }


                if (booking.EndTime < booking.StartTime)
                {
                    //Console.WriteLine($"Du kan ikke afslutte din booking før den er startet");
                    //return false;
                    message = "Du kan ikke afslutte din booking før den er startet";
                    throw new Exception(message);
                }


                if (booking.Participants > 22)
                {
                    //Console.WriteLine($"Du kan ikke have mere end 22 deltagere af gangen på din booking");
                    //return false;
                    message = "Du kan ikke have mere end 22 deltagere af gangen på din booking";
                    throw new Exception(message);
                }
            }
            return true;
        }


        public int TotalBookings()
        {
            return Bookings.Count;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}, Phone: {Phone}, Email: {Email}, TotalBookings: {TotalBookings}";
        }
    }
}
