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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ввод исходных данных и выполнение расчёта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double b = double.Parse(txtB.Text);
            double g;

            lstResult.Items.Add("Лаб.раб.№2. Выполнил Петухов Кирилл");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"B={b}");

            int n = 0;
            if (rbtSquare.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (x * b > 0.5 && x * b < 10)
                        g = Math.Exp(Math.Sinh(x)) - Math.Abs(b);
                    else if (x * b > 0.1 && x * b < 0.5)
                        g = Math.Sqrt(Math.Abs(Math.Sinh(x) + b));
                    else
                        g = 2 * Math.Pow(Math.Sinh(x), 2);
                    lstResult.Items.Add($"Результат g={Math.Round(g, 3)}");
                    break;

                case 1:
                    if (x * b > 0.5 && x * b < 10)
                        g = Math.Exp(Math.Pow(x, 2)) - Math.Abs(b);
                    else if (x * b > 0.1 && x * b < 0.5)
                        g = Math.Sqrt(Math.Abs(Math.Pow(x, 2) + b));
                    else
                        g = 2 * Math.Pow(Math.Pow(x, 2), 2);
                    lstResult.Items.Add($"Результат g={Math.Round(g, 3)}");
                    break;

                case 2:
                    if (x * b > 0.5 && x * b < 10)
                        g = Math.Exp(Math.Exp(x)) - Math.Abs(b);
                    else if (x * b > 0.1 && x * b < 0.5)
                        g = Math.Sqrt(Math.Abs(Math.Exp(x) + b));
                    else
                        g = 2 * Math.Pow(Math.Exp(x), 2);
                    lstResult.Items.Add($"Результат g={Math.Round(g, 3)}");
                    break;
            }

        }

        /// <summary>
        /// Очистить поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtB.Clear();
            lstResult.Items.Clear();
        }
    }
}
