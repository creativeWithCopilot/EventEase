using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class EventModel
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required, DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required, StringLength(100)]
    public string Location { get; set; } = string.Empty;
}
