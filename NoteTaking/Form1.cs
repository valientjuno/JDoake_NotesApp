using System;
using System.Data;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Title"].Width = 140;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // Save
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Title and Message cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void button3_Click(object sender, EventArgs e) // Read
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    txtTitle.Text = table.Rows[index]["Title"].ToString();
                    txtMessage.Text = table.Rows[index]["Message"].ToString();
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    table.Rows[index].Delete();
                    txtTitle.Clear();
                    txtMessage.Clear();
                }
            }
        }

        private void openFormSecond_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;

            if (string.IsNullOrWhiteSpace(title) && string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("No note to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 secondForm = new Form2(title, message);
            secondForm.Show();
        }
    }
}