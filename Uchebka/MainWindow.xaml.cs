using System;
using System.Windows;
using Uchebka.DataSet1TableAdapters;
namespace Uchebka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        carTableAdapter Car = new carTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            Uchebka1.ItemsSource = Car.GetData();
            
        }

    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new SecondPage();

        }

        private void PageFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Uchebka1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Car.InsertQuery(One.Text, Convert.ToInt16(Two.Text));
            Uchebka1.ItemsSource = Car.GetData();
        }
    }
}
