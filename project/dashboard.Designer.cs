namespace project
{
    partial class dashboard
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
            btnadd = new Button();
            btndelete = new Button();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            clname = new DataGridViewTextBoxColumn();
            clAge = new DataGridViewTextBoxColumn();
            clblood = new DataGridViewTextBoxColumn();
            clphone = new DataGridViewTextBoxColumn();
            clamount = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            invantoryToolStripMenuItem = new ToolStripMenuItem();
            requestsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            btnadd.Location = new Point(37, 422);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(113, 29);
            btnadd.TabIndex = 8;
            btnadd.Text = "new donation";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            btndelete.Location = new Point(199, 422);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(124, 29);
            btndelete.TabIndex = 9;
            btndelete.Text = "new request";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(37, 59);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 10;
            label1.Text = "total doners";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(281, 59);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 15;
            label6.Text = "requests";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(166, 59);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 16;
            label7.Text = "total units";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 97);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 20;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 97);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 19;
            label5.Text = "0";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 97);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 18;
            label8.Text = "0";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(385, 59);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 17;
            label2.Text = "low stock alert";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 97);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 21;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 242);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 23;
            label9.Text = "Priority requests";
            label9.Click += label9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clname, clAge, clblood, clphone, clamount });
            dataGridView1.Location = new Point(21, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 80);
            dataGridView1.TabIndex = 0;
            // 
            // clname
            // 
            clname.HeaderText = "Name";
            clname.MinimumWidth = 6;
            clname.Name = "clname";
            clname.ReadOnly = true;
            clname.Width = 125;
            // 
            // clAge
            // 
            clAge.HeaderText = "Age";
            clAge.MinimumWidth = 6;
            clAge.Name = "clAge";
            clAge.ReadOnly = true;
            clAge.Width = 125;
            // 
            // clblood
            // 
            clblood.HeaderText = "Blood Type";
            clblood.MinimumWidth = 6;
            clblood.Name = "clblood";
            clblood.ReadOnly = true;
            clblood.Width = 125;
            // 
            // clphone
            // 
            clphone.HeaderText = "Amount";
            clphone.MinimumWidth = 6;
            clphone.Name = "clphone";
            clphone.ReadOnly = true;
            clphone.Width = 150;
            // 
            // clamount
            // 
            clamount.HeaderText = "Status";
            clamount.MinimumWidth = 6;
            clamount.Name = "clamount";
            clamount.ReadOnly = true;
            clamount.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, donorsToolStripMenuItem, invantoryToolStripMenuItem, requestsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(97, 24);
            toolStripTextBox1.Text = "dashborad";
            toolStripTextBox1.Click += toolStripTextBox1_Click;
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
            requestsToolStripMenuItem.Click += requestsToolStripMenuItem_Click;
            // 
            // frmdash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1006, 506);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Name = "frmdash";
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnadd;
        private Button btndelete;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clname;
        private DataGridViewTextBoxColumn clAge;
        private DataGridViewTextBoxColumn clblood;
        private DataGridViewTextBoxColumn clphone;
        private DataGridViewTextBoxColumn clamount;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private ToolStripMenuItem invantoryToolStripMenuItem;
        private ToolStripMenuItem requestsToolStripMenuItem;
    }
}
