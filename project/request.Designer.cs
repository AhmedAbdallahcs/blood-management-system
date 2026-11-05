namespace project
{
    partial class request
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
            cmbbloodtype = new ComboBox();
            lblname = new Label();
            txtphone = new TextBox();
            txtname = new TextBox();
            label3 = new Label();
            lblphone = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            invantoryToolStripMenuItem = new ToolStripMenuItem();
            requestsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbbloodtype
            // 
            cmbbloodtype.FormattingEnabled = true;
            cmbbloodtype.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbbloodtype.Location = new Point(91, 162);
            cmbbloodtype.Name = "cmbbloodtype";
            cmbbloodtype.Size = new Size(125, 28);
            cmbbloodtype.TabIndex = 23;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblname.ImageKey = "(none)";
            lblname.Location = new Point(4, 68);
            lblname.Name = "lblname";
            lblname.Size = new Size(48, 20);
            lblname.TabIndex = 19;
            lblname.Text = "name";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(91, 115);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(125, 27);
            txtphone.TabIndex = 22;
            // 
            // txtname
            // 
            txtname.Location = new Point(91, 68);
            txtname.Name = "txtname";
            txtname.Size = new Size(125, 27);
            txtname.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(4, 162);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 21;
            label3.Text = "bloodtype";
            // 
            // lblphone
            // 
            lblphone.AutoSize = true;
            lblphone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblphone.Location = new Point(4, 115);
            lblphone.Name = "lblphone";
            lblphone.Size = new Size(53, 20);
            lblphone.TabIndex = 20;
            lblphone.Text = "phone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(4, 210);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 24;
            label1.Text = "amount";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(91, 275);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 26;
            button1.Text = "add request";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, donorsToolStripMenuItem, invantoryToolStripMenuItem, requestsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 27;
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
            // 
            // invantoryToolStripMenuItem
            // 
            invantoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invantoryToolStripMenuItem.Name = "invantoryToolStripMenuItem";
            invantoryToolStripMenuItem.Size = new Size(92, 24);
            invantoryToolStripMenuItem.Text = "Invantory";
            // 
            // requestsToolStripMenuItem
            // 
            requestsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            requestsToolStripMenuItem.Size = new Size(83, 24);
            requestsToolStripMenuItem.Text = "requests";
            // 
            // request
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(cmbbloodtype);
            Controls.Add(lblname);
            Controls.Add(txtphone);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(lblphone);
            Name = "request";
            Text = "request";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbbloodtype;
        private Label lblname;
        private TextBox txtphone;
        private TextBox txtname;
        private Label label3;
        private Label lblphone;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private ToolStripMenuItem invantoryToolStripMenuItem;
        private ToolStripMenuItem requestsToolStripMenuItem;
    }
}