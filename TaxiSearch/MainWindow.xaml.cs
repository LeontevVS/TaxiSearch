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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaxiSearch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ThrowAuthorisation();
            UpdateOrdersList();
        }

        public void ThrowAuthorisation()
        {
            Visibility = Visibility.Hidden;
            AuthorisationWindow authorization = new AuthorisationWindow(this);
            authorization.Show();
        }

        public void UpdateOrdersList() => DGridOrders.ItemsSource = Context.GetContext().Orders.ToList();

        private void Btn_Create_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow wind = new OrderWindow(this);
            wind.Show();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OrderWindow wind = new OrderWindow(this, DGridOrders.SelectedItem as Order);
            wind.Show();
        }
    }
}
