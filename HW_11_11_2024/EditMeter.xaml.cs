using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HW_11_11_2024
{
    /// <summary>
    /// Логика взаимодействия для EditMeter.xaml
    /// </summary>
    public partial class EditMeter : Window
    {
        public EditMeter(Meter meter)
        {
            InitializeComponent();
            DataContext = new Meter { Manufacturer = meter.Manufacturer, Date = meter.Date, ID = meter.ID, IsHot = meter.IsHot };
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ButtonCansel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
