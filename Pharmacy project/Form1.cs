namespace Pharmacy_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "hashimshahid" && txtpassword.Text == "pass")
            {
                administrator am = new administrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName OR Password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
