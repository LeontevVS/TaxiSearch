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
    public partial class TaxiChoiceWindow : Window
    {
        OrderWindow _ow;

        public TaxiChoiceWindow(OrderWindow ow)
        {
            InitializeComponent();
            UpdateTaxisList();
            _ow = ow;
        }

        public void UpdateTaxisList() => DGridTaxis.ItemsSource = Context.GetContext().Taxis.ToList();

        private void SetSelectedTaxi() 
        { 
            Taxi taxi = DGridTaxis.SelectedItem as Taxi;
            _ow.order.Taxi = taxi;
            _ow.order.TaxiId = taxi.Id;
            _ow.tbTaxi.Text = $"{taxi.Car.LicensePlate} {taxi.Car.Brand} {taxi.Car.Model} {taxi.Driver.Name}";
            Close();
        }

        private void btnChoice_Click(object sender, RoutedEventArgs e)
        {
            if (!(DGridTaxis.SelectedItem is null))
                SetSelectedTaxi();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SetSelectedTaxi();
        }
    }
}
