using EventEase.Models;

namespace EventEase.Services;

public class AttendanceService
{
    private readonly List<AttendanceRecord> _records = new();

    public void RegisterAttendance(int eventId, string name, string email)
    {
        _records.Add(new AttendanceRecord
        {
            EventId = eventId,
            AttendeeName = name,
            Email = email,
            IsPresent = false
        });
    }

    public void MarkPresent(int eventId, string email)
    {
        var record = _records.FirstOrDefault(r => r.EventId == eventId && r.Email == email);
        if (record is null) return;
        record.IsPresent = true;
        record.CheckInTime = DateTime.Now;
    }

    public IEnumerable<AttendanceRecord> GetEventAttendance(int eventId) =>
        _records.Where(r => r.EventId == eventId);
}
