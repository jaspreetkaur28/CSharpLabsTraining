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

namespace lab_69_WPF_Entity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<Customer> CustomerList;
        static List<Product> ProductList;
        static List<Supplier> SupplierList;
        static List<Employee> EmployeeList;
        static List<Order> OrderList;
        static List<Order_Detail> OrderDetailsList;

        static Customer customer;
        static Customer customerToEdit;
        static Customer customerToDelete;
        static Order order;
        static Order_Detail orderdetail;
        static Product product;
        static Customer newCustomer;

        private bool C = false;
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
        void Initialize()
        {
            using (var db = new NorthwindEntities())
            {
                CustomerList = db.Customers.ToList();

                ListBox1.DisplayMemberPath = "ContactName";
                ListBox1.ItemsSource = CustomerList;
            }
        }

        private void ListCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            C = true;
            ListBox1.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                CustomerList = db.Customers.ToList();

                ListBox1.DisplayMemberPath = "ContactName";
                ListBox1.ItemsSource = CustomerList;
            }
        }

        private void ListProducts_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                ProductList = db.Products.ToList();

                ListBox1.DisplayMemberPath = "ProductName";
                ListBox1.ItemsSource = ProductList;
            }
        }

        private void ListSuppliers_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                SupplierList = db.Suppliers.ToList();

                ListBox1.DisplayMemberPath = "CompanyName";
                ListBox1.ItemsSource = SupplierList;
            }

        }

        private void ListEmployees_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                EmployeeList = db.Employees.ToList();

                ListBox1.DisplayMemberPath = "LastName";
                ListBox1.ItemsSource = EmployeeList;
            }

        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListBox2.ItemsSource = null;
            ListBox3.ItemsSource = null;
            ListBox4.ItemsSource = null;
            ListBox5.ItemsSource = null;
            if (ListBox1.SelectedItem != null)
            {
                customer = (Customer)ListBox1.SelectedItem;
                using (var db = new NorthwindEntities())
                {
                    OrderList = db.Orders.Where(O => O.CustomerID == customer.CustomerID).ToList();

                    ListBox2.DisplayMemberPath = "OrderID";
                    ListBox2.ItemsSource = OrderList;
                }

                TB1.Text = customer.ContactName;
                TB2.Text = customer.CompanyName;
                TB3.Text = customer.City;
                TB1.IsReadOnly = true;
                TB2.IsReadOnly = true;
                TB3.IsReadOnly = true;


            }
        }
        private void ListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox3.ItemsSource = null;

            if (ListBox2.SelectedItem == null)
            {
                return;
            }
            order = ListBox2.SelectedItem as Order;
            orderdetail = (Order_Detail)ListBox3.SelectedItem;

            using (var db = new NorthwindEntities())
            {
                OrderDetailsList = db.Order_Details.Where(OD => OD.OrderID == order.OrderID).ToList();
                ProductList = new List<Product>();

                foreach (var item in OrderDetailsList)
                {
                    product = null;
                    product = db.Products.Where(p => p.ProductID == item.ProductID).FirstOrDefault();
                    ProductList.Add(product);
                }
                ListBox3.DisplayMemberPath = "ProductName";
                ListBox3.ItemsSource = ProductList;
            }
        }

        private void ListBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox4.ItemsSource = null;
            ListBox4.Items.Clear();

            if (ListBox4.SelectedItem == null) { return; }

            product = ListBox4.SelectedItem as Product;

            ListBox4.Items.Add(product.ProductID);
            ListBox4.Items.Add(product.ProductName);
            ListBox4.Items.Add(product.CategoryID);
            ListBox4.Items.Add(product.UnitPrice);
            ListBox4.Items.Add(product.UnitsInStock);
            ListBox4.Items.Add(product.UnitsOnOrder);
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Add.Content.ToString() == "New")
            {
                Add.Content = "Add";
                falsingtb();

                TB1.Text = "ID";
                TB2.Text = "Contact Name";
                TB3.Text = "Company Name";
                TB4.Text = "City";

                Add.IsEnabled = true;
                Edit.IsEnabled = false;
                Delete.IsEnabled = false;
            }
            else if (Add.Content.ToString() == "Add")
            {
                Add.Content = "New";
                using (var db = new NorthwindEntities())
                {
                    newCustomer = new Customer()
                    {
                        CustomerID = TB1.Text,
                        ContactName = TB2.Text,
                        CompanyName = TB3.Text,
                        City = TB4.Text,
                    };
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    nulling();
                    CustomerList = db.Customers.ToList();
                    ListBox1.ItemsSource = CustomerList;
                    Edit.IsEnabled = true;
                    Delete.IsEnabled = true;
                    falsingtb();
                }

            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (Edit.Content.ToString() == "Edit")
            {
                falsingtb();
                Edit.Content = "Save Changes";
                Add.IsEnabled = false;
                Delete.IsEnabled = false;
            }

            else if (Edit.Content.ToString() == "Save Changes")
            {
                Edit.Content = "Edit";
                using (var db = new NorthwindEntities())
                {
                    if (customer != null)
                    {
                        customerToEdit = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                        customerToEdit.ContactName = TB1.Text;
                        customerToEdit.CompanyName = TB2.Text;
                        customerToEdit.City = TB3.Text;

                        db.SaveChanges();
                    }
                    nulling();
                    CustomerList = db.Customers.ToList();
                    ListBox1.ItemsSource = CustomerList;
                    Add.IsEnabled = true;
                    Delete.IsEnabled = true;
                    falsingtb();
                }
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (customer == null) { return; }

            using (var db = new NorthwindEntities())
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete this data?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    customerToDelete = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();

                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();

                }
                else return;

                nulling();

                CustomerList = db.Customers.ToList();
                ListBox1.ItemsSource = CustomerList;
                falsingtb();

            }

            MessageBox.Show(TB1.Text + " has been deleted");

        }
        public void falsingtb()
        {
            TB1.IsReadOnly = false;
            TB2.IsReadOnly = false;
            TB3.IsReadOnly = false;
            TB4.IsReadOnly = false;
        }
        public void nulling()
        {
            TB1.Text = null;
            TB2.Text = null;
            TB3.Text = null;
            TB4.Text = null;
            ListBox1.ItemsSource = null;
            ListBox2.ItemsSource = null;
            ListBox3.ItemsSource = null;
            ListBox4.ItemsSource = null;
            ListBox5.ItemsSource = null;
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            nulling();
            TB1.IsReadOnly = false;
            TB2.IsReadOnly = false;
            TB3.IsReadOnly = false;
            TB4.IsReadOnly = false;
        }
    }
}