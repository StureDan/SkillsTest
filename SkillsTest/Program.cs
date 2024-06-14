namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave2");
            //Opgave 2
            Booking booking1 = new Booking(1, new DateTime(2024, 6, 21, 10, 0, 0), new DateTime(2024, 6, 21, 13, 0, 0), 10);
            Booking booking2 = new Booking(2, new DateTime(2024, 7, 22, 14, 0, 0), new DateTime(2024, 7, 22, 17, 0, 0), 12);
            Booking booking3 = new Booking(3, new DateTime(2024, 8, 18, 16, 0, 0), new DateTime(2024, 8, 18, 18, 0, 0), 14);
            Booking booking4 = new Booking(4, new DateTime(2024, 9, 25, 18, 0, 0), new DateTime(2024, 9, 25, 20, 0, 0), 16);

            Console.WriteLine(booking1);
            Console.WriteLine(booking2);
            Console.WriteLine(booking3);
            Console.WriteLine(booking4);

            Console.WriteLine("Opgave3");
            //Opgave 3
            GymHall gymHall = new GymHall(5, "ManaGym", "Steroidevej 2", "88888888", "steroidegym@gmail.dk");
            gymHall.AddBooking(booking1);
            gymHall.AddBooking(booking2);
            gymHall.AddBooking(booking3);
            gymHall.AddBooking(booking4);
            Console.WriteLine(gymHall);

            Console.WriteLine("Opgave4");
            //Opgave 4
            // Registerbooking test
            gymHall.RegisterBooking(booking1);
            gymHall.RegisterBooking(booking2);
            gymHall.RegisterBooking(booking3);
            gymHall.RegisterBooking(booking4);

            // Printbookings test
            Console.WriteLine("nuværende bookinger:");
            gymHall.PrintBookings();

            // Removebooknig test
            gymHall.RemoveBooking(3);

            // printerbookings efter fjernelse
            Console.WriteLine("bookinger efter fjernelse:");
            gymHall.PrintBookings();

            // Prøver at fjerne en booking, der ikke findes
            gymHall.RemoveBooking(999999);

            //Opgave 6
            //Total bookings test
            Console.WriteLine("Opgave 6");
            Console.WriteLine($"TotalBookings: {gymHall.Bookings.Count}");

            //Opgave 7
            //Validate metode test
            Console.WriteLine("Opgave 7");
            Console.WriteLine("Validerer bookings:");
            bool isValid = gymHall.Validate();
            Console.WriteLine($" {isValid}");

            //Opgave 8
            //Exception try-catch test
            Console.WriteLine("Opgave 8");
            try
            {
                gymHall.Validate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //bookingduration og sundaybooking test
            Console.WriteLine(booking1);
            Console.WriteLine(booking2);
            Console.WriteLine(booking3);
            Console.WriteLine(booking4);

        }
    }
}
