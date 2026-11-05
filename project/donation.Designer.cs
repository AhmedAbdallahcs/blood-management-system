namespace project
{
    partial class donation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbbloodtype = new ComboBox();
            lblname = new Label();
            txtphone = new TextBox();
            txtname = new TextBox();
            label3 = new Label();
            lblphone = new Label();
            btnadddonation = new Button();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            invantoryToolStripMenuItem = new ToolStripMenuItem();
            requestsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(13, 211);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 15;
            label1.Text = "birth date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 27);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbbloodtype
            // 
            cmbbloodtype.FormattingEnabled = true;
            cmbbloodtype.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbbloodtype.Location = new Point(100, 157);
            cmbbloodtype.Name = "cmbbloodtype";
            cmbbloodtype.Size = new Size(125, 28);
            cmbbloodtype.TabIndex = 13;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblname.ImageKey = "(none)";
            lblname.Location = new Point(13, 51);
            lblname.Name = "lblname";
            lblname.Size = new Size(48, 20);
            lblname.TabIndex = 9;
            lblname.Text = "name";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(100, 104);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(125, 27);
            txtphone.TabIndex = 12;
            // 
            // txtname
            // 
            txtname.Location = new Point(100, 51);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 8;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 159);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 11;
            label3.Text = "bloodtype";
            // 
            // lblphone
            // 
            lblphone.AutoSize = true;
            lblphone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblphone.Location = new Point(13, 105);
            lblphone.Name = "lblphone";
            lblphone.Size = new Size(53, 20);
            lblphone.TabIndex = 10;
            lblphone.Text = "phone";
            // 
            // btnadddonation
            // 
            btnadddonation.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnadddonation.Location = new Point(100, 266);
            btnadddonation.Name = "btnadddonation";
            btnadddonation.Size = new Size(135, 29);
            btnadddonation.TabIndex = 20;
            btnadddonation.Text = "add donation";
            btnadddonation.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, donorsToolStripMenuItem, invantoryToolStripMenuItem, requestsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(97, 24);
            toolStripTextBox1.Text = "dashborad";
            // 
            // donorsToolStripMenuItem
            // 
            donorsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            donorsToolStripMenuItem.Size = new Size(72, 24);
            donorsToolStripMenuItem.Text = "donors";
            donorsToolStripMenuItem.Click += donorsToolStripMenuItem_Click;
            // 
            // invantoryToolStripMenuItem
            // 
            invantoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invantoryToolStripMenuItem.Name = "invantoryToolStripMenuItem";
            invantoryToolStripMenuItem.Size = new Size(92, 24);
            invantoryToolStripMenuItem.Text = "Invantory";
            invantoryToolStripMenuItem.Click += invantoryToolStripMenuItem_Click;
            // 
            // requestsToolStripMenuItem
            // 
            requestsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            requestsToolStripMenuItem.Size = new Size(83, 24);
            requestsToolStripMenuItem.Text = "requests";
            // 
            // donation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(btnadddonation);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbbloodtype);
            Controls.Add(lblname);
            Controls.Add(txtphone);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(lblphone);
            Name = "donation";
            Text = "donation";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbbloodtype;
        private Label lblname;
        private TextBox txtphone;
        private TextBox txtname;
        private Label label3;
        private Label lblphone;
        private Button btnadddonation;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private ToolStripMenuItem invantoryToolStripMenuItem;
        private ToolStripMenuItem requestsToolStripMenuItem;
    }
}