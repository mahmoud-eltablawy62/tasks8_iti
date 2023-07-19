namespace calculator_DeskApp
{
    public partial class Form1 : Form
    {
        public object MassageBox { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_password.Text == "262002")
            {
                Form2 calc = new Form2();
                this.Hide();
                calc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("password is incorrect");
            }
        }
    }
}