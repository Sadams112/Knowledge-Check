namespace KnowledgeCheck2;

public class Oak : Wood_Species
{

    public string Type { get; set; }

    public string Grain { get; set; }


    public override string ToString()
    {
        return "Oak " + Type + " " + Grain;
    }
}