using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task2StudentsSemechev
{
    public partial class FormMain : Form
    {
        List<Student> students;
        public FormMain()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void FromDGVToList(DataGridView dgv)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                Student student = new Student()
                {
                    FirstName = dgv[0, i].Value.ToString(),
                    LastName = dgv[1, i].Value.ToString()
                };
                List<int> grades = new List<int>();
                for (int j = 2; j < dgv.ColumnCount; j++)
                {
                    grades.Add(Convert.ToInt32(dgv[j, i].Value));
                }
                student.TestResults = grades;
                students.Add(student);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            dGV.RowCount = Convert.ToInt32(tBStudents.Text);
            dGV.ColumnCount = 2 + Convert.ToInt32(tBTests.Text);

            for (int i = 2; i < dGV.ColumnCount; i++)
            {
                dGV.Columns[i].HeaderText = "Test " + (i - 1);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            FromDGVToList(dGV);

            for (int i = 0; i < students.Count; i++)
            {
                stringBuilder.AppendLine(students[i].ToString());
            }

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
