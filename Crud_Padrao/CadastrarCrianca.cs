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
    public partial class CadastrarCrianca : Form
    {
        Crianca c1 = new Crianca();
        string idade;
        public CadastrarCrianca()
        {
            InitializeComponent();
        }

        private void CadastrarCrianca_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            principal.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c1.nome = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            idade = textBox2.Text;
        }

        private void Genero_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Masculino.Checked)
                c1.genero = 'M';
        }

        private void Genero_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Feminino.Checked)
                c1.genero = 'F';
        }

        private void Genero_Outro_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Outro.Checked)
                c1.genero = 'O';
        }

        private void Bomzinho_True_CheckedChanged(object sender, EventArgs e)
        {
            if (Bomzinho_True.Checked)
                c1.bomzinho = true;
        }

        private void Bomzinho_False_CheckedChanged(object sender, EventArgs e)
        {
            if (Bomzinho_True.Checked)
                c1.bomzinho = false;
        }
    }
}
