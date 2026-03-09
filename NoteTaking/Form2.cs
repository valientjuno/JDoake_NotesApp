using System;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form2 : Form
    {
        public Form2(string title, string message)
        {
            InitializeComponent();
            lblTitle.Text = title;              // Display title from Form1
            txtMessageForm2.Text = message;     // Display message from Form1
        }

        private void backForm_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form2 and return to Form1
        }
    }
}