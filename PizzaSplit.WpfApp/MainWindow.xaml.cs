using PizzaSplit.Core;
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

namespace PizzaSplit.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal total;
            int people;

            if (!decimal.TryParse(txtTotal.Text, out total))
            {
                txtResult.Text = "Vale summa";
                return;
            }

            if (!int.TryParse(txtPeople.Text, out people))
            {
                txtResult.Text = "Vale inimeste arv";
                return;
            }

            if (BillCalculator.TryCalculate(
                total,
                people,
                chkTip.IsChecked == true,
                out decimal share,
                out string error))
            {
                txtResult.Text = $"Tulemus: {share:F2} €";
            }
            else
            {
                txtResult.Text = error;
            }
        }

        private void txtPeople_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}