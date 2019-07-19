using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class EndForm : Form
    {       
        public EndForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }

        private void EndForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
