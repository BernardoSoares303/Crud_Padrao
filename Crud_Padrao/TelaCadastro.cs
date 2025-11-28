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

namespace Crud_Padrao
{
    public partial class TelaCadastro : Form
    {
        string usuario;
        string senha;
        string senhacrip;
        static Form1 f1 = new Form1();
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

        private void Usuario_Text_TextChanged(object sender, EventArgs e)
        {
            usuario = Usuario_Text.Text;
        }

        private void Senha_Text_TextChanged(object sender, EventArgs e)
        {
            senha = Senha_Text.Text;

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Converte bytes para string hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                senhacrip = sb.ToString();
            }   
        }
    }
}
