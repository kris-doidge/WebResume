namespace WebResume.Domain
{
    public class Technology
    {
        public string Name { get; set; }
        public TechnologyType TechnologyType { get; set; }
    }

    public enum TechnologyType
    {
        Software,
        OperatingSystems,
        Languages
    }
}