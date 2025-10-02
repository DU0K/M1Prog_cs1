/*
🏨 Hotel Booking Variables Exercise
You're designing a simple data model for a hotel booking system. Your task is to declare and assign variables that represent the following details for a single guest's reservation:
- Guest's full name
- Number of nights booked
- Room type (e.g., "Single", "Double", "Suite")
- Price per night
- Whether breakfast is included
- Check-in date
- Total cost of the stay
Use appropriate data types for each variable and assign realistic values to them.
*/

namespace variableopdracht2;

class Program
{
    static void Main(string[] args)
    {
        string fullName = "Elvis Presley";
        int numberOfNights = 7;
        string roomType = "Suite";
        double pricePerNight = 240.77;
        bool breakfastIncluded = true;
        string checkInDate = " 18/09/2025";
        double totalCost = pricePerNight * numberOfNights;
        Console.WriteLine("Full Name " + fullName);
        Console.WriteLine("numberOfNights " + numberOfNights);
        Console.WriteLine("roomType " + roomType);
        Console.WriteLine("pricePerNight " + pricePerNight);
        Console.WriteLine("breakfastIncluded " + breakfastIncluded);
        Console.WriteLine("checkInDate " + checkInDate);
        Console.WriteLine("totalcost " + totalCost);
    }
}
