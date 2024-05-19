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

namespace WpfItemsControlsExtApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public enum Position
    {
        Manager,
        Developer,
        Driver
    }

    public partial class MainWindow : Window
    {
        List<Employee> employees;

        public MainWindow()
        {
            InitializeComponent();

            employees = new List<Employee>()
            {
                new(){ Name = "Bobby", 
                       Age = 27, 
                       Company = "Yandex",
                       Position = Position.Manager,
                       IsMarried = true},
                new(){ Name = "Sammy", Age = 32, Company = "Ozon",
                            Position = Position.Developer,
                            IsMarried = false},
                new(){ Name = "Jimmy", Age = 45, Company = "Avito",
                            Position = Position.Driver,
                            IsMarried = true }
            };

            ListBox listBoxCompanies = new ListBox();
            listBoxCompanies.Items.Add("Yandex");
            listBoxCompanies.Items.Add("Ozon");
            listBoxCompanies.Items.Add("Avito");
            listBoxCompanies.Items.Add("Google");

            StackPanel stack = new();
            TextBlock txt = new(new Run("Hello world"));
            stack.Children.Add(txt);

            tabControlExample.Items.Add(new TabItem()
            {
                Header = stack,
                Content = listBoxCompanies
            });

            var cars = new TreeViewItem() { Header = "Cars" };
            cars.Items.Add(new TreeViewItem() { Header = "Lada" });

            tree.Items.Add(cars);

            dataGridEmployees.ItemsSource = employees;
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach (var emp in employees)
                str += emp.ToString() + "\n";
            MessageBox.Show(str);
        }
    }
}