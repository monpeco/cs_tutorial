using System;
using System.Collections.Generic;
using System.Windows;

namespace Mod_9_Homework
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		public List<Student> StudentsList = new List<Student>();
		private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
		{
			var student = new Student(txtFirstName.Text, txtLastName.Text,txtCity.Text);
			StudentsList.Add(student);

			txtFirstName.Clear();
			txtLastName.Clear();
			txtCity.Clear();
		}
		int? _index=null;

		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				if (_index==null || _index >= StudentsList.Count - 1)
				{
					_index=0;
					txtFirstName.Text = StudentsList[(int)_index].StudentsFirstName;
					txtLastName.Text = StudentsList[(int)_index].StudentsLastName;
					txtCity.Text = StudentsList[(int)_index].StudentsCity;
				}
				else
				{
					_index++;
					txtFirstName.Text = StudentsList[(int)_index].StudentsFirstName;
					txtLastName.Text = StudentsList[(int)_index].StudentsLastName;
					txtCity.Text = StudentsList[(int)_index].StudentsCity;
				}
			}
			catch (Exception eX)
			{
				MessageBox.Show(eX.Message + "\n \nYou must create at least one student");
			}

		}

		private void btnPrevious_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				if (_index == null||_index<=0)
				{
					_index = StudentsList.Count-1;
					txtFirstName.Text = StudentsList[(int)_index].StudentsFirstName;
					txtLastName.Text = StudentsList[(int)_index].StudentsLastName;
					txtCity.Text = StudentsList[(int)_index].StudentsCity;
				}
				else
				{
					_index--;
					txtFirstName.Text = StudentsList[(int)_index].StudentsFirstName;
					txtLastName.Text = StudentsList[(int)_index].StudentsLastName;
					txtCity.Text = StudentsList[(int)_index].StudentsCity;
				}
			}
			catch (Exception eX)
			{
				MessageBox.Show(eX.Message+"\n \nYou must create at least one student");
			}

		}

		public class Student
		{
			private string firstName;
			private string lastName;
			private string city;
			
			public Student(string firstName, string lastName, string city)
			{
				this.StudentsFirstName = firstName;
				this.StudentsLastName = lastName;
				this.StudentsCity = city;
			}
			public string StudentsFirstName
			{
				get { return firstName; }
				set { firstName = value; }
			}
			public string StudentsLastName
			{
				get { return lastName; }
				set { lastName = value; }
			}
			public string StudentsCity
			{
				get { return city; }
				set { city = value; }
			}
		}
	}
}