namespace pannella.analoguepocket;

public class Core
{
    public string? identifier { get; set; }
    public Repo? repository { get; set; }
    public string? platform { get; set; }

    public override string ToString()
    {
        return platform;
    }
}