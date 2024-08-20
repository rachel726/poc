namespace moduleA;

public static class moduleADbProperties
{
    public static string DbTablePrefix { get; set; } = "moduleA";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "moduleA";
}
