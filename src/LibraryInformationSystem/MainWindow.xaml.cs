using System.Windows;
namespace LibraryInformationSystem;
public partial class MainWindow : Window { public MainWindow(){InitializeComponent();} private void CheckButton_Click(object sender, RoutedEventArgs e){StatusText.Text="Проект успешно запущен.";} }
