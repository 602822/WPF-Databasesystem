using Assignment3_v2.ModelsDB2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment3_v2
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    { 
        
      public Dat154Context datacontex { get; set; }


       




        public Editor(Dat154Context context)
        {
            InitializeComponent();
            
            datacontex = context;
            courseList.ItemsSource = datacontex.Courses.Select(c => c.Coursecode).ToList();
            
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {

            var selectedCourse = courseList.SelectedItem;

            Student student = new Student()
            {
                Id = int.Parse(idTextBox.Text),
                Studentname = nameTextBox.Text,
                Studentage = int.Parse(ageTextBox.Text),
                
            };

            Grade grade = new Grade()
            {
                Coursecode = selectedCourse.ToString(),
                Grade1 = gradeTextBox.Text,
                Student = student,
            };

            datacontex.Add(student);
            student.Grades.Add(grade);
            datacontex.SaveChanges();
        }

        private void deleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            Student student = datacontex.Students.Where(student => student.Id == id).First();
            Grade grade = datacontex.Grades.Where(grade => grade.Studentid == id).First();

            if (student != null)
            {


                
                datacontex.Grades.Remove(grade);
                datacontex.Students.Remove(student);
              
                
                datacontex.SaveChanges();


            }


        }
    }
}
