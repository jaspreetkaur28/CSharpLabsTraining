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

namespace lab_52_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // static Customer customers;
        static List<Customer> customers;
        public MainWindow()
        {
            InitializeComponent();
            Button01.Content = "Sequence";
            Button01.FontSize = 30;
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                foreach (var customer in customers)
                {
                    ListBox01.Items.Add(customer.ContactName);
                }
                ListBox02.ItemsSource = db.Customers.ToList(); // shows lab_52_WPF:Customer
            }
        }
    }
}
