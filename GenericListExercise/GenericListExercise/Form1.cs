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
                EnterGrade(299, "F");
                EnterGrade(349, "D");
                EnterGrade(399, "C");
                EnterGrade(449, "B");
                EnterGrade(500, "A");


                AllGrades.Add(grade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void EnterGrade(int maxGrade, string gradeLetter)
        {
            grade.MaxGrade = maxGrade;
            grade.GradeLetter = gradeLetter;

            AllGrades.Add(grade);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Varify user entered int greater than 0
            if (!uint.TryParse(txtScore.Text, out uint submittedGrade))
            {
                MessageBox.Show("Please enter a valid number");

                txtScore.Focus();
                txtScore.SelectAll();

                return;
            }

            //Finds the maximum grade possible
            int maximumGrade = 0;
            foreach (Grades grade in AllGrades)
            {
                if (grade.MaxGrade > Convert.ToInt32(maximumGrade))
                {
                    maximumGrade = grade.MaxGrade;
                }
            }

            //Varify if user entered value below maximum possible grade
            if (submittedGrade > maximumGrade)
            {
                MessageBox.Show($"Entered grade must be below the maximum value of {maximumGrade}.");
                return;
            }

            //Finds and displays grade assoicated with entered value.
            foreach (Grades grade in AllGrades)
            {
                if (submittedGrade <= grade.MaxGrade)
                {
                    MessageBox.Show($"Grade letter for: {submittedGrade} {Environment.NewLine} " +
                        $"is: {grade.GradeLetter}");

                    txtScore.Focus();
                    txtScore.SelectAll();

                    return;
                }
            }
        }
    }


}
