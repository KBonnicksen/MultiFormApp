using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormApp
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnOpenAddStudentForm_Click(object sender, EventArgs e)
        {
            frmAddStudent addStuForm = new frmAddStudent();
            DialogResult result = addStuForm.ShowDialog();

            if(result == DialogResult.OK) //saved student
            {
                string student = addStuForm.getStuName();
                MessageBox.Show($"Thanks for adding {student}");
            }
            else
            {
                MessageBox.Show("Thanks for nothing ya dirty animal1");
            }
        }
    }
}
