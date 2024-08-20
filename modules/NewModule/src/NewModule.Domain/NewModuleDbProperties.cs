namespace NewModule;

public static class NewModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "NewModule";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "NewModule";
}
