namespace ConsoleApp7;

public class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent(string name, string memberId) : base(name, memberId)
    {
        
    }

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Thesis research update");
    }
}