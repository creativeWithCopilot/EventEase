namespace EventEase.Models;

public class AttendanceRecord
{
    public int EventId { get; set; }
    public string AttendeeName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsPresent { get; set; }
    public DateTime? CheckInTime { get; set; }
}
