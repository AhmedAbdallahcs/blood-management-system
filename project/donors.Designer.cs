namespace project
{
    partial class donors
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cldonid = new DataGridViewTextBoxColumn();
            clname = new DataGridViewTextBoxColumn();
            clAge = new DataGridViewTextBoxColumn();
            clblood = new DataGridViewTextBoxColumn();
            cllastdate = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            invantoryToolStripMenuItem = new ToolStripMenuItem();
            requestsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 27);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cldonid, clname, clAge, clblood, cllastdate });
            dataGridView1.Location = new Point(19, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 83);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 58);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // cldonid
            // 
            cldonid.HeaderText = "Don Id";
            cldonid.MinimumWidth = 6;
            cldonid.Name = "cldonid";
            cldonid.ReadOnly = true;
            cldonid.Width = 125;
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
            // cllastdate
            // 
            cllastdate.HeaderText = "Last Donation";
            cllastdate.MinimumWidth = 6;
            cllastdate.Name = "cllastdate";
            cllastdate.ReadOnly = true;
            cllastdate.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1, donorsToolStripMenuItem, invantoryToolStripMenuItem, requestsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 19;
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
            // donors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "donors";
            Text = "donors";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn cldonid;
        private DataGridViewTextBoxColumn clname;
        private DataGridViewTextBoxColumn clAge;
        private DataGridViewTextBoxColumn clblood;
        private DataGridViewTextBoxColumn cllastdate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private ToolStripMenuItem invantoryToolStripMenuItem;
        private ToolStripMenuItem requestsToolStripMenuItem;
    }
}