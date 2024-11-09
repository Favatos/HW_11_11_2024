using System.Diagnostics.Metrics;
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

namespace HW_11_11_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Meter { Date = new DateTime(2024, 11, 11), ID = 1, IsHot = true, Manufacturer = "Water meters" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditMeter edit = new EditMeter((Meter)DataContext);
            if (edit.ShowDialog() == true)
            {
                DataContext = edit.DataContext;
            }
        }
    }
}