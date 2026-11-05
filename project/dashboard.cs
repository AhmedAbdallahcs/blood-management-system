namespace project
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dasdsdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            donation d1 = new donation();
            d1.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            request d2 = new request();
            d2.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donors d3 = new donors();
            d3.Show();
        }

        private void invantoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invantory d4 = new invantory();
            d4.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            requests d5 = new requests();
            d5.Show();
        }
    }
}