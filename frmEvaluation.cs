using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class frmEvaluation : Form
    {
        private Student selectedStudent = null;
        public frmEvaluation(Student student)
        {
            this.selectedStudent = student;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateActivities();
            SetFormTitle();
        }

        private void SetFormTitle()
        {
            this.Text = $"{selectedStudent.FirstName} {selectedStudent.LastName}";
        }

        private void PopulateActivities()
        {
            cboActivities.DataSource = ActivityRepository.GetActivity();
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = selectedActivity.Description;
            txtMinForGrade.Text = selectedActivity.MinPointsForGrade + " / " + selectedActivity.MaxPoints;
            txtMinForSignature.Text = selectedActivity.MinPointsForSignature + " / " + selectedActivity.MaxPoints;

            numPoints.Minimum = 0;
            numPoints.Maximum = selectedActivity.MaxPoints;
        }
    }
}
