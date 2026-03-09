using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteTaking
{
    partial class Form1
    {
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Button bttNew;
        private Button button2;   // Save
        private Button button3;   // Read
        private Button bttDelete;
        private Button openFormSecond;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            bttNew = new Button();
            button2 = new Button();
            button3 = new Button();
            bttDelete = new Button();
            openFormSecond = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            this.SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(84, 64);
            label1.Text = "Title:";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(55, 112);
            label2.Text = "Message:";

            // txtTitle
            txtTitle.Location = new Point(131, 61);
            txtTitle.Size = new Size(125, 27);

            // txtMessage
            txtMessage.Location = new Point(131, 112);
            txtMessage.Multiline = true;
            txtMessage.Size = new Size(275, 180);

            // dataGridView1
            dataGridView1.Location = new Point(450, 61);
            dataGridView1.Size = new Size(305, 231);
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;

            // bttNew
            bttNew.Location = new Point(162, 345);
            bttNew.Size = new Size(94, 29);
            bttNew.Text = "New";
            bttNew.Click += bttNew_Click;

            // button2 - Save
            button2.Location = new Point(286, 345);
            button2.Size = new Size(94, 29);
            button2.Text = "Save";
            button2.Click += button2_Click;

            // button3 - Read
            button3.Location = new Point(406, 345);
            button3.Size = new Size(94, 29);
            button3.Text = "Read";
            button3.Click += button3_Click;

            // bttDelete
            bttDelete.Location = new Point(524, 345);
            bttDelete.Size = new Size(94, 29);
            bttDelete.Text = "Delete";
            bttDelete.Click += bttDelete_Click;

            // openFormSecond
            openFormSecond.Location = new Point(31, 345);
            openFormSecond.Size = new Size(125, 29);
            openFormSecond.Text = "Open Second Form";
            openFormSecond.Click += openFormSecond_Click;

            // Form1
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(openFormSecond);
            this.Controls.Add(bttDelete);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(bttNew);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(txtMessage);
            this.Controls.Add(txtTitle);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Text = "Notes App";
            this.Load += new EventHandler(Form1_Load);

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}