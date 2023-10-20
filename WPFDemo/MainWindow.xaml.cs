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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public List<Person> listOfPersons = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            listOfPersons.Add(new Person { FirstName = "Tarek", LastName= "Gustavsson" });
            listOfPersons.Add(new Person { FirstName = "Anton", LastName= "Sharma" });
            listOfPersons.Add(new Person { FirstName = "Mosa", LastName= "Verma" });
            this.Background = new SolidColorBrush(Colors.White);
            ComboBox.ItemsSource= listOfPersons;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {FirstNameText.Text}");
            Window2 window2= new Window2();
            window2.Show();

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
