using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridPG;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MessageBoxButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello");
    }

    private async void FillTableButton_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        DataTable dt = await Utilities.GenerateDataTableWithNRowsAsync(3000000);
        
        Debug.WriteLine($"Generating DataTable took: {stopwatch.ElapsedMilliseconds}ms");

        stopwatch.Restart();

        dataGrid.ItemsSource = dt.DefaultView;
        
        Debug.WriteLine($"Setting ItemsSource took: {stopwatch.ElapsedMilliseconds}ms");

    }
}