using MyClasses;
class Program
{
    static void Main()
    {
        EventManager manager = new EventManager();

        manager.AddEvent(new Event("Qwerty", "Test", new DateTime(2024, 8, 10, 9, 0, 0), new DateTime(2024, 8, 10, 10, 0, 0)));
        manager.AddEvent(new Event("BackEnd", "Dev", new DateTime(2024, 8, 11, 11, 0, 0), new DateTime(2024, 8, 11, 15, 0, 0)));
        manager.AddEvent(new Event("Holiday", "12345", new DateTime(2024, 8, 10, 14, 0, 0), new DateTime(2024, 8, 10, 18, 0, 0)));
        manager.RemoveEvent("Holiday");
        var eventsOnDate = manager.FindEventsByDate(new DateTime(2024, 8, 10));
        Console.WriteLine("Events on 2024-08-10:");
        foreach (var ev in eventsOnDate)
        {
            Console.WriteLine($"Title: {ev.Title}, \nDescription: {ev.Description}, \nStart Time: {ev.StartTime}, \nEnd Time: {ev.EndTime}");
        }
    }
}