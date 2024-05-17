using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service;
public class EventService
{
    public async Task<List<EventData>> GetEventsAsync()
    {
        // Simula la obtención de datos de una fuente externa
        await Task.Delay(1000);
        return new List<EventData>
            {
                new EventData { Id = 1, Text = "Event 1", Start = DateTime.Now, End = DateTime.Now.AddHours(1) },
                new EventData { Id = 2, Text = "Event 2", Start = DateTime.Now.AddDays(1), End = DateTime.Now.AddDays(1).AddHours(2) },
                new EventData { Id = 3, Text = "Event 3", Start = DateTime.Now.AddDays(2), End = DateTime.Now.AddDays(2).AddHours(3) }
            };
    }
}

public class EventData
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}