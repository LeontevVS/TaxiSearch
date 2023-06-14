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

namespace TaxiSearch
{
    /// <summary>
    /// Логика взаимодействия для CarRentsWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public Order order;
        MainWindow _mw;

        public OrderWindow(MainWindow mw, Order order = null)
        {
            InitializeComponent();
            _mw = mw;
            if (order is null)
                this.order = new Order() 
                { 
                    Id = 0, 
                    Date = DateTime.Now
                };
            else
            {
                this.order = order;
                tbTaxi.Text = $"{order.Taxi.Car.LicensePlate} {order.Taxi.Car.Brand} {order.Taxi.Car.Model} {order.Taxi.Driver.Name}";
            }

            DataContext = this.order;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e) => Save();

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Несохраненные изменения будут утеряны.\nЗакрыть окно?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Close();
        }

        private bool Save()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(tbAddressFrom.Text))
                errors.AppendLine("Укажите адрес отправления");
            if (string.IsNullOrWhiteSpace(tbAddressTo.Text))
                errors.AppendLine("Укажите адрес назначения");
            if (string.IsNullOrWhiteSpace(tbTaxi.Text))
                errors.AppendLine("Укажите такси");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (order.Id == 0)
                Context.GetContext().Orders.Add(order);

            try
            {
                Context.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
        {
            if (Save())
                Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _mw.UpdateOrdersList();
        }

        private void btnChoice_Click(object sender, RoutedEventArgs e)
        {
            TaxiChoiceWindow window = new TaxiChoiceWindow(this);
            window.Show();
        }
    }
}
