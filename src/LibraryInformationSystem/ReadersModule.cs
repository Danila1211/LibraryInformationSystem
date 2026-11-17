namespace LibraryInformationSystem;
public sealed class Reader
{
    public int Id { get; init; }
    public string FullName { get; init; } = "";
    public string Phone { get; init; } = "";
}
public static class ReadersModule
{
    public static List<Reader> CreateSample() => new()
    {
        new Reader { Id = 1, FullName = "Иванов Иван", Phone = "+7 900 100-10-10" },
        new Reader { Id = 2, FullName = "Петрова Анна", Phone = "+7 900 200-20-20" }
    };
}
