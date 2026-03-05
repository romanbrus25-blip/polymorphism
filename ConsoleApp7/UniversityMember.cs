namespace ConsoleApp7;

public class UniversityMember
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value) ? 
            throw new Exception("Invalid name") : value;
    }
    
    public string MemberId { get; private set; }

    protected List<string> ActionLog = new List<string>();

    public UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }
    
    public int ActionCount => ActionLog.Count;

    public virtual void PerformDuties()
    {
        if (this.ActionLog.Count == 5)
        {
            throw new Exception("The member has already reached a daily limit of 5 actions");
        }
    }
}