namespace ContactForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContact = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            SuspendLayout();
            // 
            // dgvContact
            // 
            dgvContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Location = new Point(119, 229);
            dgvContact.Name = "dgvContact";
            dgvContact.RowTemplate.Height = 25;
            dgvContact.Size = new Size(489, 184);
            dgvContact.TabIndex = 0;
            dgvContact.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvContact);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContact;
    }
}