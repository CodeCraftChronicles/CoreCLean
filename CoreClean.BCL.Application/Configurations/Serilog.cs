namespace CoreClean.BCL.Application.Configurations;

public class Serilog
{
    public Minimumlevel MinimumLevel { get; set; }
    public Writeto[] WriteTo { get; set; }
    public string[] Enrich { get; set; }
    public Properties Properties { get; set; }
}

public class Minimumlevel
{
    public string Default { get; set; }
    public Override Override { get; set; }
}

public class Override
{
    public string Microsoft { get; set; }
    public string MicrosoftHostingLifetime { get; set; }
    public string System { get; set; }
    public string Hangfire { get; set; }
}

public class Properties
{
    public string Application { get; set; }
}

public class Writeto
{
    public string Name { get; set; }
    public Args Args { get; set; }
}

public class Args
{
    public string outputTemplate { get; set; }
    public string path { get; set; }
    public string rollingInterval { get; set; }
}
