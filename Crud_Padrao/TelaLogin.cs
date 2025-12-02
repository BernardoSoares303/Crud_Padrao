using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Crud_Padrao
{
    public partial class TelaLogin : Form
    {
        string usuario;
        string senha;
        string senhacrip;
        static Form1 f1 = new Form1();
        int voltar = 1;

        static string conexao = "Server=127.0.0.1;Port=3306;Database=Natal;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai

        TelaPrincipal principal = new TelaPrincipal();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Usuario_Text_TextChanged(object sender, EventArgs e)
        {
            usuario = Usuario_Text.Text;
        }

        private void Senha_Text_TextChanged(object sender, EventArgs e)
        {
            senha = Senha_Text.Text;
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] bytes =
                sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)

                    sb.Append(b.ToString("x2"));
                senhacrip = sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarLogin(usuario, senhacrip) == 1)
            {
                voltar = 0;
                this.Close();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!");
            }
        }
        static int ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string querySelect = $@"select count(id_usuario) from usuarios where nome_usuario = '{usuario}' and senha_usuario = '{senha}';";

                using (MySqlCommand cmd = new MySqlCommand(querySelect, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                    return count;
                }
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(voltar == 1)
            {
                f1.Show();
            }
        }
    }
}
