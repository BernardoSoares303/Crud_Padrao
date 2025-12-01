using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud_Padrao
{
    public partial class TelaCadastro : Form
    {
        string usuario;
        string senha;
        string senhacrip;
        static Form1 f1 = new Form1();

        static string conexao = "Server=127.0.0.1;Port=3307;Database=Natal;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai

        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (inserirdados(usuario, senhacrip))
            {
                MessageBox.Show("Cadastro Realizado Com sucesso!");
                this.Close();
            }
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

        static bool inserirdados(string usuario, string senha)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string queryinsert = @"insert into usuarios (nome_usuario, senha_usuario) values (@nome_usuario, @senha_usuario);";
                    MySqlCommand cmd = new MySqlCommand(queryinsert, conn);

                    cmd.Parameters.AddWithValue("@nome_usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha_usuario", senha);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }

        }

    }
}
