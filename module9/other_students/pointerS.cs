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
	public partial class MainWindow : Window
	{
		// List of students.
		List<Student> students = new List<Student>();

		// Pointer to students list.
		int pointerS = -1;

		public MainWindow()
		{
			InitializeComponent();

			// There are not students in the list at the beginning.
			btnNext.IsEnabled = false;
			btnPrevious.IsEnabled = false;
		}

		// Create New Student Handler.
		private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
		{
			// Create and add the new student to the list.
			string fName = txtFirstName.Text;
			string lName = txtLastName.Text;
			string city = txtCity.Text;
			Student student = new Student(fName, lName, city);
			this.students.Add(student);

			// Clear the contents of the text boxes.
			txtFirstName.Clear();
			txtLastName.Clear();
			txtCity.Clear();

			// Update buttons.
			updateButtons();
		}

		// Next Student Handler.
		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			this.pointerS++;
			showStudentInfo(this.students[this.pointerS]);
			updateButtons();
		}

		// Previous Student Handler.
		private void btnPrevious_Click(object sender, RoutedEventArgs e)
		{
			this.pointerS--;
			showStudentInfo(this.students[this.pointerS]);
			updateButtons();
		}

		// Show student info in the app window.
		private void showStudentInfo(Student s)
		{
			txtFirstName.Text = s.FirstName;
			txtLastName.Text = s.LastName;
			txtCity.Text = s.City;
		}

		// Enable or disable next and previous buttons.
		private void updateButtons()
		{
			btnNext.IsEnabled = !(this.pointerS == (this.students.Count - 1));
			btnPrevious.IsEnabled = !(this.pointerS <= 0);
		}
	}
}