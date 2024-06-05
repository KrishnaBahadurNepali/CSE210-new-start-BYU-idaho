using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Address instances
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Oak St", "London", "", "UK");

        // Create Event instances
        Event event1 = new Lecture("C# Basics", "Introduction to C# programming language", new DateTime(2024, 6, 15), new TimeSpan(9, 0, 0), address1, "John Doe", 50);
        Event event2 = new Reception("Networking Event", "Networking event for professionals", new DateTime(2024, 6, 20), new TimeSpan(18, 0, 0), address2, "info@example.com");
        Event event3 = new OutdoorGathering("Summer Picnic", "Annual company picnic", new DateTime(2024, 7, 1), new TimeSpan(12, 0, 0), address3, "Sunny");

        // Display marketing messages for each event
        Console.WriteLine("Event 1 Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.StandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(event1.FullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(event1.ShortDescription());
    }
}

