using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreateUser : Form
    {
        public static Color color = Color.FromArgb(255, 192, 192);
        MainForm newMain = null;
        public CreateUser(MainForm OldMain)
        {
            InitializeComponent();
            newMain = OldMain;
            this.BackColor = CreateUser.color;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                this.BackColor = color;
                TxtThemeColor.BackColor = color;
                BtnApply.BackColor = color;
                label1.BackColor = color;
                TxtThemeColor.Text = color.ToString();
                newMain.panel1.BackColor = color;
                newMain.panel2.BackColor = color;
                newMain.panel3.BackColor = color;
                newMain.panel4.BackColor = color;
                newMain.panel5.BackColor = color;
            }
        }
    }
}
