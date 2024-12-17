using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Clsses;

namespace WindowsFormsApp1.Forms
{
    public partial class Composition : Form
    {
        public Composition()
        {
            InitializeComponent();
        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            //DECLARE
            Course course = new Course();
            string str = "";

            //INPUT
           
            course.CourseID = int.Parse(txtCId.Text);
            course.CourseName = txtCN.Text;
            course.Start = Start.Value;
            course.End = End.Value;
            course.Duratin = TimeSpan.Parse(txtDuration.Text);  
            course.Fee = float.Parse(txtFee.Text);

            course.student.StudentID = int.Parse(txtSD.Text);
            course.student.FullName = txtFn.Text;
            course.student.Sex = CbbSex.Text;
            course.student.ContactNo = txtContact.Text;

            //PROCESS
            str = course.PrintReceipt(course.student.StudentID, course.student.FullName, course.student.Sex, course.student.ContactNo);
            //OUTPUT
            MessageBox.Show(str, "Composition Class");
        }
    }
}
