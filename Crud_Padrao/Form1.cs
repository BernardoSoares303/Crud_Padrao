namespace Crud_Padrao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastro tc = new TelaCadastro();
            tc.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
