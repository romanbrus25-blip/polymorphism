namespace ConsoleApp7;

public class UniversityRegistry
{
    private List<UniversityMember> members = new List<UniversityMember>();

    public void AddMember(UniversityMember m)
    {
        members.Add(m);
    }
    
    public void ExecuteAllDuties()
    {
        foreach (var m in members)
        {
            m.PerformDuties();
        }
    }

    public string GetMemberStatistics()
    {
        int TotalActions = 0;
        foreach (var m in members)
        {
            TotalActions += m.ActionCount;
        }
        return $"Total actions: {TotalActions}, Total members: {members.Count}";
    }
}