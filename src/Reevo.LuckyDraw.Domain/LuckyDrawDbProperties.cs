namespace Reevo.LuckyDraw;

public static class LuckyDrawDbProperties
{
    public static string DbTablePrefix { get; set; } = "LuckyDraw";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "LuckyDraw";
}
