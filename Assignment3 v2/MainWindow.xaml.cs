using Assignment3_v2.ModelsDB2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Assignment3_v2
{
    public partial class MainWindow : Window
    {
        private readonly Dat154Context datacontex = new Dat154Context();

        LocalView<Student> Students;
        LocalView<Course> Courses;
        LocalView<Grade> Grades;


        public MainWindow()
        {
            InitializeComponent();
            Students = datacontex.Students.Local;
            Courses = datacontex.Courses.Local;
            Grades = datacontex.Grades.Local;

            datacontex.Courses.Load();
            datacontex.Students.Load();
            datacontex.Grades.Load();


            studentList.DataContext = Students.OrderBy(student => student.Studentname);



            //Legger til curskodene fra databasen inn i kursvelgelisten
            selectCource.ItemsSource = datacontex.Courses.Select(c => c.Coursecode).ToList();

            //Legger til karakterene fra databasen inn i karaktervelgelisten
            selectGrade.ItemsSource = datacontex.Grades.Select(g => g.Grade1).OrderBy(grade => grade).Distinct().ToList();



        }

        private void searchField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Søkefunksjon der du kan søke på ein student ved navn
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            studentList.DataContext = Students.Where(student => student.Studentname.Contains(searchField.Text))
                            .OrderBy(student => student.Studentname);

        }


        //Får tak i studentene som har kurset som er valgt
        private void selectCource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

          

            var result = from student in Students
                         join grade in Grades on student.Id equals grade.Studentid
                         join course in Courses on grade.Coursecode equals course.Coursecode
                         where course.Coursecode.Equals(selectCource.SelectedValue)
                         select new { student.Id, student.Studentname, grade.Grade1 };


            if (result != null)
            {
                studentList.DataContext = result;
            }
        }


        //Viser Studenter som har høgere eller lik den karakteren du valgte
        private void selectGrade_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            var result = from student in Students
                         join grade in Grades on student.Id equals grade.Studentid
                         join course in Courses on grade.Coursecode equals course.Coursecode

                         where grade.Grade1.CompareTo(selectGrade.SelectedValue) <= 0  // Fiks, ikkje riktig endo

                         select new { student.Id, student.Studentname, course.Coursecode, grade.Grade1 };



            if (result != null)
            {
                studentList.DataContext = result;
            }
        }

        private void studentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //Finner studenter med Karakter F
        private void failedStudentsCheckBox_Checked(object sender, RoutedEventArgs e)
        {


            if (failedStudentsCheckBox.IsChecked == true)
            {
                var result = from student in Students
                             join grade in Grades on student.Id equals grade.Studentid
                             join course in Courses on grade.Coursecode equals course.Coursecode

                             where grade.Grade1.Equals("F")

                             select new { student.Id, student.Studentname, course.Coursecode, grade.Grade1 };

                
                if (result != null)
                {
                    studentList.DataContext = result;
                }



            }
        }

        //Opner Editoren
        private void editButton_Click(object sender, RoutedEventArgs e)
        {

            Editor editor = new(datacontex)
            {
                datacontex = datacontex

            };

            
            editor.Show();

        }
    }
}



