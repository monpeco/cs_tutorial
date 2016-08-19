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

namespace Mod_9_Homework
{
    //Declaring Class Student
    public class Student
    {
        // constructor
        public Student(string firstName, string lastName, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            Console.WriteLine("\nfirstName: {0},\nlastName: {1}, \ncity: {2}", this.firstName, this.lastName, this.city);
        }
        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
    }
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> studentsList = new List<Student>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student(txtFirstName.text, txtLastName.text, txtCity.text);
            studentsList.Add(student);
            Console.WriteLine("Student {0} Added", s.firstName);
            MessageBox.Show("Student Added");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }
    }
}
