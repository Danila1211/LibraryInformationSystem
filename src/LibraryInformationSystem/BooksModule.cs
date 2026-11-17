namespace LibraryInformationSystem;
public sealed class Book
{
    public int Id { get; init; }
    public string Title { get; init; } = "";
    public string Author { get; init; } = "";
    public int PublishedYear { get; init; }
}
public static class BooksModule
{
    public static List<Book> CreateSample() => new()
    {
        new Book { Id = 1, Title = "Мастер и Маргарита", Author = "Михаил Булгаков", PublishedYear = 1967 },
        new Book { Id = 2, Title = "Преступление и наказание", Author = "Фёдор Достоевский", PublishedYear = 1866 },
        new Book { Id = 3, Title = "Война и мир", Author = "Лев Толстой", PublishedYear = 1869 }
    };
}
