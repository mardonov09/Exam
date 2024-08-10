using Microsoft.VisualBasic;

namespace MyClasses
{
    public class Event
    {
      public string? Title { get; set; }
      public string? Description { get; set; }
      public DateTime StartTime { get; set; }
      public DateTime EndTime { get; set; }
      public Event (string? title, string description, DateTime startTime, DateTime endTime)
      {
        Title = title;
        Description = description;
        StartTime = startTime;
        EndTime = endTime;
      }
    }

    public class EventManager
    {
    private List<Event> events = new List<Event>();
    public void AddEvent(Event newEvent)
    {
      events.Add(newEvent);
    }
    public void RemoveEvent(string title)
    {
      events.RemoveAll(e => e.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
    public List<Event> FindEventsByDate(DateTime date)
    {
      return events.Where(e => e.StartTime.Date == date.Date || e.EndTime.Date == date.Date).ToList();
    }
  }
    // - Класс `Event` должен содержать следующие свойства:
    //   - Название - `string`
    //   - Описание - `string`
    //   - Время начала - `DateTime`
    //   - Время окончания - `DateTime`
    // Методы:

    // - Реализуйте методы для добавления события

    // - Удалите событие по имени.

    // - Поиск событий, которые происходят в определенный день.

    // Создайте несколько событий, добавьте их в менеджер, удалите одно из событий и найдите все события, которые происходят в определенный день.
}
