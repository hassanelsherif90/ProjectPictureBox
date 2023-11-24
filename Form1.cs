using ProjectPictureBox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdBook_CheckedChanged(object sender, EventArgs e)
        {
            pcbType.Image = Resources.Book;
            lblTitle.Text = ((RadioButton) sender).Tag.ToString();
        }

        private void rdGirl_CheckedChanged(object sender, EventArgs e)
        {
            pcbType.Image = Resources.Girl;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdBoy_CheckedChanged(object sender, EventArgs e)
        {
            pcbType.Image = Resources.Boy;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rdPen_CheckedChanged(object sender, EventArgs e)
        {
            pcbType.Image = Resources.Pen;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }
    }
}
