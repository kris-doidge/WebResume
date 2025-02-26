using System.Collections.Generic;
using System.Linq;
using WebResume.Domain;

namespace WebResume.Data;

public interface ITechnologyData
{
    IEnumerable<Technology> GetAllSoftware();
    IEnumerable<Technology> GetAllLanguages();
    IEnumerable<Technology> GetAllOperatingSystems();
}

public class TechnologyData : ITechnologyData
{
    private readonly List<Technology> _technologiesData;

    public TechnologyData()
    {
        _technologiesData = new List<Technology>
        {
            new() { Name = "Microsoft VSTS", TechnologyType = TechnologyType.Software },
            new() { Name = "Azure DevOps", TechnologyType = TechnologyType.Software },
            new() { Name = "SQL Server Management Studio", TechnologyType = TechnologyType.Software },
            new() { Name = "Visual Studios", TechnologyType = TechnologyType.Software },
            new() { Name = "JetBrains Rider", TechnologyType = TechnologyType.Software },
            new() { Name = "Oracle VM Virtual Box", TechnologyType = TechnologyType.Software },
            new() { Name = "Microsoft Office", TechnologyType = TechnologyType.Software },
            new() { Name = "Microsoft Windows", TechnologyType = TechnologyType.OperatingSystems },
            new() { Name = "Mac OS", TechnologyType = TechnologyType.OperatingSystems },
            new() { Name = "Ubuntu", TechnologyType = TechnologyType.OperatingSystems },
            new() { Name = "C# (.NET / .NET Core)", TechnologyType = TechnologyType.Languages },
            new() { Name = "C++", TechnologyType = TechnologyType.Languages },
            new() { Name = "C", TechnologyType = TechnologyType.Languages },
            new() { Name = "Javascript", TechnologyType = TechnologyType.Languages },
            new() { Name = "React", TechnologyType = TechnologyType.Languages },
            new() { Name = "HTML", TechnologyType = TechnologyType.Languages },
            new() { Name = "SQL", TechnologyType = TechnologyType.Languages }
        };
    }

    public IEnumerable<Technology> GetAllSoftware()
    {
        return from r in _technologiesData
            where r.TechnologyType == TechnologyType.Software
            select r;
    }

    public IEnumerable<Technology> GetAllLanguages()
    {
        return from r in _technologiesData
            where r.TechnologyType == TechnologyType.Software
            select r;
    }

    public IEnumerable<Technology> GetAllOperatingSystems()
    {
        return from r in _technologiesData
            where r.TechnologyType == TechnologyType.OperatingSystems
            select r;
    }
}