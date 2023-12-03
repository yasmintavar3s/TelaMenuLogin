using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "RRT" & textBox2.Text == "123")
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta");
                    }
        }
    }
}
