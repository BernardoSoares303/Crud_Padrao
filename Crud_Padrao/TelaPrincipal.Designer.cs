namespace Crud_Padrao
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adicionar_Crianca = new Button();
            Editar_Crianca = new Button();
            Ver_Crianca = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Adicionar_Crianca
            // 
            Adicionar_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Adicionar_Crianca.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            Adicionar_Crianca.Location = new Point(225, 49);
            Adicionar_Crianca.Name = "Adicionar_Crianca";
            Adicionar_Crianca.Size = new Size(328, 92);
            Adicionar_Crianca.TabIndex = 0;
            Adicionar_Crianca.Text = "Cadastrar Criança";
            Adicionar_Crianca.UseVisualStyleBackColor = false;
            Adicionar_Crianca.Click += Adicionar_Crianca_Click;
            // 
            // Editar_Crianca
            // 
            Editar_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Editar_Crianca.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            Editar_Crianca.Location = new Point(225, 183);
            Editar_Crianca.Name = "Editar_Crianca";
            Editar_Crianca.Size = new Size(328, 92);
            Editar_Crianca.TabIndex = 1;
            Editar_Crianca.Text = "Editar Crianças Cadastradas";
            Editar_Crianca.UseVisualStyleBackColor = false;
            Editar_Crianca.Click += Editar_Crianca_Click;
            // 
            // Ver_Crianca
            // 
            Ver_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Ver_Crianca.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            Ver_Crianca.Location = new Point(225, 318);
            Ver_Crianca.Name = "Ver_Crianca";
            Ver_Crianca.Size = new Size(328, 92);
            Ver_Crianca.TabIndex = 2;
            Ver_Crianca.Text = "Ver Crianças Cadastradas";
            Ver_Crianca.UseVisualStyleBackColor = false;
            Ver_Crianca.Click += Ver_Crianca_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__1_;
            pictureBox1.Location = new Point(-20, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 146, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(Ver_Crianca);
            Controls.Add(Editar_Crianca);
            Controls.Add(Adicionar_Crianca);
            Controls.Add(pictureBox1);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            FormClosing += TelaPrincipal_FormClosing;
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Adicionar_Crianca;
        private Button Editar_Crianca;
        private Button Ver_Crianca;
        private PictureBox pictureBox1;
    }
}