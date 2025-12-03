using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Padrao
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Adicionar_Crianca_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarCrianca cc = new CadastrarCrianca();
            cc.Show();
        }

        private void Editar_Crianca_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarCrianca ec = new EditarCrianca();
            ec.Show();
        }

        private void Ver_Crianca_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExibirCrianca exibirCrianca = new ExibirCrianca(); 
            exibirCrianca.Show();
        }
    }
}
