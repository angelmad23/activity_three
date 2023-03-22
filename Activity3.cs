using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class otherTextbox : Form
    {
        public otherTextbox()
        {
            InitializeComponent();
        }

        private void Survey_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            string str = " ";
            //Checkbox1 = Japan
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += "";
            }
            //Checkbox2 = Paris
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += "";
            }
            //Checkbox3 = U.S.A
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += "";
            }
            //Checkbox4 = Dubai
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += "";
            }
            if (str != null)
            {
                MessageBox.Show("You Selected :\n"+ str+ "\nThank you!", "Survey",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (othersLabel.Checked == false)
            {
                othersLabel.Visible = false;
                othersTextBox.Visible = false;
            }
            else
            {
                othersLabel.Visible = true;
                othersTextBox.Visible = true;
            }
            
                
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void otherTextbox_Load(object sender, EventArgs e)
        {
            

        }

        private void othersTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
