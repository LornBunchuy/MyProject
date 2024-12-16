using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Request : Form
    {
        public static Form sForm = null;
        public Request()
        {
            InitializeComponent();
        }

        private void bttLeaveR_Click(object sender, EventArgs e)
        {
            OpenForm(new NewRequestForm());
        }

        private void Request_Load(object sender, EventArgs e)
        {
            OpenForm(new NewRequestForm()); 
        }
        public void OpenForm(Form childForm)//order
        {
            if (sForm != null)
                sForm.Close();
            sForm = childForm;  //sForm = order
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bttLeaveH_Click(object sender, EventArgs e)
        {
            OpenForm(new LeaveHistoryForm());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
