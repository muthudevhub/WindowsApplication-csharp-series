using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleInterestApp
{
    public partial class LoopingExamplesForm : Form
    {
        public LoopingExamplesForm()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            lstForLoopData.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                lstForLoopData.Items.Add($"Number: {i}");

            }
        }

        private void btnForEachLoop_Click(object sender, EventArgs e)
        {
            lstForLoopData.Items.Clear();
            string[] students = { "Alice", "Muthu", "Charlie", "Diana", "Ethan" };
            int index = 1;
            foreach (var student in students)
            {
                lstForLoopData.Items.Add($"{index}.Student Name: {student}");
                index++;
            }
        }

        private void btnStudentNameForLoop_Click(object sender, EventArgs e)
        {
            lstForLoopData.Items.Clear();
            string[] students = { "Alice", "Muthu", "Charlie", "Diana", "Ethan" };

            for (int i = 0; i < students.Length; i++)
            {
                lstForLoopData.Items.Add($"{i + 1}.Student Name: {students[i]}");
            }
        }
    }
}

