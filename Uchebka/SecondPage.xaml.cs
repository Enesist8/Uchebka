using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
using Uchebka.DataSet1TableAdapters;

namespace Uchebka
{
        
    public partial class SecondPage : Page
    {
        priceTableAdapter price = new priceTableAdapter();
        carTableAdapter Car = new carTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            Price.ItemsSource = price.GetData();
            shest.ItemsSource = Car.GetData();
            shest.DisplayMemberPath = "Name";
            shest.SelectedValuePath = "id";
        }

        private void Price_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page2_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            (Application.Current.MainWindow as MainWindow).PageFrame.Content = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id = (int)shest.SelectedValue;
            price.InsertQuery(tri.Text,Convert.ToInt16(chetire.Text), id);
            Price.ItemsSource = price.GetData();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
