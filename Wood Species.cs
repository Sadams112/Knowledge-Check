namespace KnowledgeCheck2;

public class Wood_Species
{
    public string Type { get; set; }

    public string Grain { get; set; }

    public string Color { get; set; }

    public int Age { get; set; }

    public Wood_Species(string type, string grain, string color, int age)
    {
        Type = type;

        Grain = grain;

        Color = color;

        Age = age;
    }
}