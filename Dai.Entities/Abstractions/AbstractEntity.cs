namespace Dai.Entities.Abstractions;

public class AbstractEntity : BaseEFEntity
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }
    public string? Image { get; set; }
    public string? ImageHead { get; set; }

    public int Level { get; set; }
    public int BarWidth { get; set; }

}