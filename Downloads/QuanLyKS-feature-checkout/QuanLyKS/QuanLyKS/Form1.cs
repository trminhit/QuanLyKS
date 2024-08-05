namespace QuanLyKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "MinhIT" && txtPassword.Text == "123")
            {
                labelError.Visible = false; 
                Dashboard ds = new Dashboard();
                this.Hide(); 
                ds.Show();

            }
            else
            {
                labelError.Visible = true;  
                txtPassword.Clear();
            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
