namespace LibraryInformationSystem;
public sealed class Loan
{
    public int Id { get; init; }
    public int BookId { get; init; }
    public int ReaderId { get; init; }
    public DateTime IssuedAt { get; init; }
    public DateTime? ReturnedAt { get; set; }
}
public static class LoansModule
{
    public static List<Loan> CreateSample() => new()
    {
        new Loan { Id = 1, BookId = 1, ReaderId = 1, IssuedAt = new DateTime(2026, 11, 10) }
    };
}
