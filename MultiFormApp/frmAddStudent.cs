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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private string stuName;

        private void btnSave_Click(object sender, EventArgs e)
        {
            stuName = txtStudentName.Text;
            //hypothetically save to database here
            MessageBox.Show("Thanks, student saved");

            DialogResult = DialogResult.OK;
            Close();
        }

        public string getStuName()
        {
            return stuName;
        }
    }
}
