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
using lab_44_entity;

namespace hw_104_WPF_Northwind_entity_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customerList;
        static List<Employee> EmployeeList;
        static List<Product> ProductList;
        static List<Supplier> SupplierList;
        static List<Order> OrderList;
        static List<Order_Detail> ODList;
        static Customer customer;
        static Order order;
        static Order_Detail od;

        private bool CustomersButton = false;
        private bool EmployeeButton = false;
        private bool ProductButton = false;
        private bool SupplierButton = false;

        public MainWindow()
        {
            InitializeComponent();

            #region Title
            Title.Content = "   Northwind Database";
            Title.FontSize = 30;
            Customers.Content = "Customers";
            Customers.FontSize = 20;
            Employees.Content = "Employees";
            Employees.FontSize = 20;
            Products.Content = "Products";
            Products.FontSize = 20;
            Suppliers.Content = "Suppliers";
            Suppliers.FontSize = 20;
            #endregion

        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        { 

            CustomersButton = true;
            EmployeeButton = false;
            ProductButton = false;
            SupplierButton = false;
            ListBox1.ItemsSource = null;
            ListBox2.ItemsSource = null;
            ListBox3.ItemsSource = null;
            using (var db = new NorthwindEntities2())
            {
                customerList = db.Customers.ToList();

                ListBox1.DisplayMemberPath = "ContactName";
                ListBox1.ItemsSource = customerList;

            }

        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            CustomersButton = false;
            EmployeeButton = true;
            ProductButton = false;
            SupplierButton = false;
            ListBox1.ItemsSource = null;
            ListBox2.ItemsSource = null;
            ListBox3.ItemsSource = null;
            using (var db = new NorthwindEntities2())
            {
                EmployeeList = db.Employees.ToList();

                ListBox1.DisplayMemberPath = "FirstName";
                ListBox1.ItemsSource = EmployeeList;

            }

        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            CustomersButton = false;
            EmployeeButton = false;
            ProductButton = true;
            SupplierButton = false;
            ListBox1.ItemsSource = null;
            ListBox2.ItemsSource = null;
            ListBox3.ItemsSource = null;
            using (var db = new NorthwindEntities2())
            {
                ProductList = db.Products.ToList();

                ListBox1.DisplayMemberPath = "ProductName";
                ListBox1.ItemsSource = ProductList;

            }
        }

        private void Suppliers_Click(object sender, RoutedEventArgs e)
        {
            CustomersButton = false;
            EmployeeButton = false;
            ProductButton = false;
            SupplierButton = true;

            ListBox1.ItemsSource = null;
            ListBox2.ItemsSource = null;
            ListBox3.ItemsSource = null;

            using (var db = new NorthwindEntities2())
            {
                SupplierList = db.Suppliers.ToList();

                ListBox1.DisplayMemberPath = "ContactName";
                ListBox1.ItemsSource = SupplierList;

            }
        }


        private void Customernext()
        {

        }
        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomersButton == true)
            {
                customer = (Customer)ListBox1.SelectedItem;
                using (var db = new NorthwindEntities2())
                {
                    OrderList = db.Orders.Where(o => o.CustomerID == customer.CustomerID).ToList();
                    ListBox2.DisplayMemberPath = "OrderID";
                    ListBox2.ItemsSource = OrderList;

                }
            }
            else ListBox2.ItemsSource = null;

        }
        private void ListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                order = (Order)ListBox2.SelectedItem;
                using (var db = new NorthwindEntities2())
                {
                    ODList = db.Order_Details.Where(od => od.OrderID == order.OrderID).ToList();
                    ListBox3.DisplayMemberPath = "ProductID";
                    ListBox3.ItemsSource = ODList; 
                }

        }
        private void ListBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }


        }
}