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

namespace P14_2
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
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txt1.Text;
            string enrollment = txt2.Text;
            string email = txt3.Text;
            string mobile = txt4.Text;
            string semester = cmb1.Text;
            string gender = rd1.IsChecked == true ? "Male" : "Female";
            string birthdate = dtp1.SelectedDate.HasValue ? dtp1.SelectedDate.Value.ToShortDateString() : "";

            string message = $"Full Name: {fullName}\nEnrollment: {enrollment}\nEmail: {email}\nMobile: {mobile}\nSemester: {semester}\nGender: {gender}\nBirthdate: {birthdate}";

            MessageBox.Show(message, "Student Details");
        }

    }
}
