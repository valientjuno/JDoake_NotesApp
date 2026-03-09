using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteTaking
{
    partial class Form2
    {
        private Button backForm;
        private Label lblTitle;
        private TextBox txtMessageForm2;

        private void InitializeComponent()
        {
            backForm = new Button();
            lblTitle = new Label();
            txtMessageForm2 = new TextBox();

            // Form2 properties
            this.SuspendLayout();
            this.ClientSize = new Size(800, 450);
            this.Name = "Form2";
            this.Text = "Form2";

            // lblTitle - displays note title
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(400, 30);
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // txtMessageForm2 - displays note message
            txtMessageForm2.Location = new Point(20, 60);
            txtMessageForm2.Size = new Size(400, 300);
            txtMessageForm2.Multiline = true;
            txtMessageForm2.ReadOnly = true;

            // backForm - Go Back button
            backForm.Location = new Point(682, 12);
            backForm.Size = new Size(94, 29);
            backForm.Text = "Go Back";
            backForm.UseVisualStyleBackColor = true;
            backForm.Click += backForm_Click;

            // Add controls to form
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtMessageForm2);
            this.Controls.Add(backForm);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}