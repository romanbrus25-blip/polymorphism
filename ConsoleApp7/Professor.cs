namespace ConsoleApp7;

public class Professor : UniversityMember
{
    public Professor(string name, string memberId) : base(name, memberId)
    {
        
    }
    public override void PerformDuties()
    {
        base.PerformDuties();  
        ActionLog.Add("Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        Console.WriteLine($"Conducting {topic}");
        ActionLog.Add($"Conducted research on {topic}");
    }
}