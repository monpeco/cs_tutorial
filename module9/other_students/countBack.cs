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

namespace mod9
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List <Student> students = new List<Student>();
		int countNext = students.size -1; 
		int countBack = 0;

		public MainWindow()
		{
			InitializeComponent();
		} 
	
		private void btnCreateStudent_Click(object sender, RoutedEventArgs e){

			Student student = new Student (string firstName, string lastName, string program);
			student.FirstName = txtFirstName.Text;
			student.LastName = txtLastName.Text;
			student.Program = txtProgram.Text;

			MessageBox.Show("Student created");	

			students.add(student);

			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtProgram.Text = "";

		}

		private void btnNext_Click(object sender, RoutedEventArgs e){

			if(countNext >= 0)
			{
				txtFirstName.Text = students.get(countNext).FirstName;
				txtLastName.Text = students.get(countNext).LastName;	
				txtProgram.Text = students.get(countNext).Program;
				countNext--;
				countBack = 0;	
			}	
		}

		private void btnBack_Click (object sender, RoutedEventArgs e){

			if(countBack <= students.size -1)
			{
				txtFirstName.Text = students.get(countBack).FirstName;
				txtLastName.Text = students.get(countBack).LastName;	
				txtProgram.Text = students.get(countBack).Program;
				countBack++:
				countNext=students.size -1;
			}	

		}

	}
}

public class Student 
{
	private string firstName;
	private string lastName; 
	private string program; 

	public string FirstName
	{
		get{return firstName;}
		set{firstName = value;}
	} 

	public string LastName
	{
		get{return lastName;}
		set{lastName = value;}
	}

	public string Program
	{
		get{return program;}
		set{program = value;}
	} 
}