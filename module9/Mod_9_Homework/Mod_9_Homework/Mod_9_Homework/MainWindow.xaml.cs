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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    
    //Add a new class to the project to represent a Student
    public class Student
    {
        // constructor
        public Student(string firstName, string lastName, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
        }
        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }

    }
    
    public partial class MainWindow : Window
    {
    	int currentPosition = 0, countStudents = 0;
    	List<Student> studentsList = new List<Student>();       //Create a collection to store Student objects
        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("1) This example has 3 students preloaded\n2) To add a student, first click on txtFirstName (to clean all TextBox)");

            studentsList.Add(new Student("Joe", "Smith", "Chicago"));
            studentsList.Add(new Student("Sam", "Jones", "Houston"));
            studentsList.Add(new Student("Mike", "Glavine", "San Diego"));

            var student = studentsList[0];
            txtFirstName.Text = student.firstName;
            txtLastName.Text = student.lastName;
            txtCity.Text = student.city;
			//MessageBox.Show("Hello World!");
        }
		void btnCreateStudent_Click(object sender, RoutedEventArgs e)
		{
            var student = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            studentsList.Add(student);
            MessageBox.Show("Student Added");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            MessageBox.Show("Clean the TextBox");
            student = studentsList[0];
            txtFirstName.Text = student.firstName;
            txtLastName.Text = student.lastName;
            txtCity.Text = student.city;
            countStudents++;
		}
		private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            var student = studentsList[(--currentPosition) % studentsList.Count];
            txtFirstName.Text = student.firstName;
            txtLastName.Text = student.lastName;
            txtCity.Text = student.city;
        }

        private void txtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var student = studentsList[(++currentPosition) % studentsList.Count];
            txtFirstName.Text = student.firstName;
            txtLastName.Text = student.lastName;
            txtCity.Text = student.city;
        }
    }
}
