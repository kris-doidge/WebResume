using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using WebResume.Domain;

namespace WebResume.Data
{
    public interface ITechnologyData
    {
        IEnumerable<Technology> GetAllSoftware();
        IEnumerable<Technology> GetAllLanguages();
        IEnumerable<Technology> GetAllOperatingSystems();
    }
    
    public class TechnologyData : ITechnologyData
    {
        private List<Technology> _technologiesData;

        public TechnologyData()
        {
            _technologiesData = new List<Technology>
            {
                new Technology {Name = "Microsoft VSTS", TechnologyType = TechnologyType.Software},
                new Technology {Name = "Azure DevOps", TechnologyType = TechnologyType.Software},
                new Technology {Name = "SQL Server Management Studio", TechnologyType = TechnologyType.Software},
                new Technology {Name = "Visual Studios", TechnologyType = TechnologyType.Software},
                new Technology {Name = "JetBrains Rider", TechnologyType = TechnologyType.Software},
                new Technology {Name = "Oracle VM Virtual Box", TechnologyType = TechnologyType.Software},
                new Technology {Name = "Microsoft Office", TechnologyType = TechnologyType.Software},
                new Technology {Name = "Microsoft Windows", TechnologyType = TechnologyType.OperatingSystems},
                new Technology {Name = "Mac OS", TechnologyType = TechnologyType.OperatingSystems},
                new Technology {Name = "Ubuntu", TechnologyType = TechnologyType.OperatingSystems},
                new Technology {Name = "C# (.NET / .NET Core)", TechnologyType = TechnologyType.Languages},
                new Technology {Name = "C++", TechnologyType = TechnologyType.Languages},
                new Technology {Name = "C", TechnologyType = TechnologyType.Languages},
                new Technology {Name = "Javascript", TechnologyType = TechnologyType.Languages},
                new Technology {Name = "React", TechnologyType = TechnologyType.Languages},
                new Technology {Name = "HTML", TechnologyType = TechnologyType.Languages},
                new Technology {Name = "SQL", TechnologyType = TechnologyType.Languages},
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
}