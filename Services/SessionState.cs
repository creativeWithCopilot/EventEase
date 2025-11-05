namespace EventEase.Services;

public class SessionState
{
    public string? UserName { get; private set; }
    public string? Email { get; private set; }
    public bool IsRegistered { get; private set; }

    public void Register(string name, string email)
    {
        UserName = name;
        Email = email;
        IsRegistered = true;
    }

    public void Clear()
    {
        UserName = null;
        Email = null;
        IsRegistered = false;
    }
}
