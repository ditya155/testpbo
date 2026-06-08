using testpbo.Properties.view;

namespace testpbo
{
    public partial class     login : Form
    {
        private string username;
        private string password;
        public login()
        {
            InitializeComponent();
            username = "admin123";
            password = "admin123";
            TBpass.UseSystemPasswordChar = true;
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = TBuser.Text;
            string pass = TBpass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Boss Masukan user sama passnya ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if (user == username && pass == password)
            {
                MessageBox.Show("Silahkan Masuk Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                berandaadmin DbAdmin1 = new berandaadmin();
                DbAdmin1.Show();
                this.Hide();
            }
            
            //else
            //{
            //    MessageBox.Show("user sama passnya salah bos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
