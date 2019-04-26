using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListExercise
{
    public struct Grades
    {
        public string GradeLetter;
        public int MaxGrade;
    }

    public partial class Form1 : Form
    {
        private Grades grade;
        ArrayList AllGrades = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                grade.MaxGrade = 299;
                grade.GradeLetter = "F";

                AllGrades.Add(grade);

                grade.MaxGrade = 349;
                grade.GradeLetter = "D";

                AllGrades.Add(grade);

                grade.MaxGrade = 399;
                grade.GradeLetter = "C";

                AllGrades.Add(grade);

                grade.MaxGrade = 449;
                grade.GradeLetter = "B";

                AllGrades.Add(grade);

                grade.MaxGrade = 500;
                grade.GradeLetter = "A";

                AllGrades.Add(grade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
    

}
