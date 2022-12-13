namespace Spotlight.Entities;

public class Show : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string HouseImage { get; set; }
    public ICollection<Controller> Controllers { get; set; } = new HashSet<Controller>();
    public ICollection<Sequence> Sequences { get; set; } = new HashSet<Sequence>();
    public ICollection<Model> Models { get; set; } = new HashSet<Model>();
}
