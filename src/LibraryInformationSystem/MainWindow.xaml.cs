using System.Windows;
namespace LibraryInformationSystem;
public partial class MainWindow : Window
{
    private readonly List<Book> _books = BooksModule.CreateSample();
    private readonly List<Reader> _readers = ReadersModule.CreateSample();
    private readonly List<Loan> _loans = LoansModule.CreateSample();
    public MainWindow() { InitializeComponent(); ShowBooks(); }
    private void ShowBooks() { SectionTitle.Text = "Каталог книг"; RecordsGrid.ItemsSource = _books; StatusText.Text = $"Книг: {_books.Count}"; }
    private void Books_Click(object sender, RoutedEventArgs e) => ShowBooks();
    private void Readers_Click(object sender, RoutedEventArgs e) { SectionTitle.Text = "Читатели"; RecordsGrid.ItemsSource = _readers; StatusText.Text = $"Читателей: {_readers.Count}"; }
    private void Loans_Click(object sender, RoutedEventArgs e) { SectionTitle.Text = "Выдачи книг"; RecordsGrid.ItemsSource = _loans; StatusText.Text = $"Выдач: {_loans.Count}"; }
    private void Check_Click(object sender, RoutedEventArgs e)
    {
        bool valid = _books.Select(b => b.Id).Distinct().Count() == _books.Count
            && _readers.Select(r => r.Id).Distinct().Count() == _readers.Count
            && _loans.All(l => _books.Any(b => b.Id == l.BookId) && _readers.Any(r => r.Id == l.ReaderId))
            && _loans.Where(l => l.ReturnedAt is null).GroupBy(l => l.BookId).All(g => g.Count() == 1);
        StatusText.Text = valid ? "Проверка пройдена: модули совместимы, ссылки корректны." : "Ошибка проверки: нарушена целостность данных.";
        MessageBox.Show(StatusText.Text, "Проверка интеграции", MessageBoxButton.OK, valid ? MessageBoxImage.Information : MessageBoxImage.Warning);
    }
}
