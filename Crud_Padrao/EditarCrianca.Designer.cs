namespace Crud_Padrao
{
    partial class EditarCrianca
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
            Bomzinho = new GroupBox();
            Bomzinho_False = new RadioButton();
            Bomzinho_True = new RadioButton();
            Generos = new GroupBox();
            Genero_Outro = new RadioButton();
            Genero_Feminino = new RadioButton();
            Genero_Masculino = new RadioButton();
            Editar_Crianca = new Button();
            label4 = new Label();
            Nome_Crianca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            Idade_Crianca = new TextBox();
            Id_Crianca = new TextBox();
            Bomzinho.SuspendLayout();
            Generos.SuspendLayout();
            SuspendLayout();
            // 
            // Bomzinho
            // 
            Bomzinho.Controls.Add(Bomzinho_False);
            Bomzinho.Controls.Add(Bomzinho_True);
            Bomzinho.Location = new Point(207, 244);
            Bomzinho.Name = "Bomzinho";
            Bomzinho.Size = new Size(161, 48);
            Bomzinho.TabIndex = 22;
            Bomzinho.TabStop = false;
            // 
            // Bomzinho_False
            // 
            Bomzinho_False.AutoSize = true;
            Bomzinho_False.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Bomzinho_False.Location = new Point(82, 16);
            Bomzinho_False.Name = "Bomzinho_False";
            Bomzinho_False.Size = new Size(77, 26);
            Bomzinho_False.TabIndex = 1;
            Bomzinho_False.TabStop = true;
            Bomzinho_False.Text = "False";
            Bomzinho_False.UseVisualStyleBackColor = true;
            Bomzinho_False.CheckedChanged += Bomzinho_False_CheckedChanged;
            // 
            // Bomzinho_True
            // 
            Bomzinho_True.AutoSize = true;
            Bomzinho_True.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Bomzinho_True.Location = new Point(6, 16);
            Bomzinho_True.Name = "Bomzinho_True";
            Bomzinho_True.Size = new Size(70, 26);
            Bomzinho_True.TabIndex = 0;
            Bomzinho_True.TabStop = true;
            Bomzinho_True.Text = "True";
            Bomzinho_True.UseVisualStyleBackColor = true;
            Bomzinho_True.CheckedChanged += Bomzinho_True_CheckedChanged;
            // 
            // Generos
            // 
            Generos.Controls.Add(Genero_Outro);
            Generos.Controls.Add(Genero_Feminino);
            Generos.Controls.Add(Genero_Masculino);
            Generos.Location = new Point(167, 182);
            Generos.Name = "Generos";
            Generos.Size = new Size(327, 48);
            Generos.TabIndex = 21;
            Generos.TabStop = false;
            // 
            // Genero_Outro
            // 
            Genero_Outro.AutoSize = true;
            Genero_Outro.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Genero_Outro.Location = new Point(244, 16);
            Genero_Outro.Name = "Genero_Outro";
            Genero_Outro.Size = new Size(78, 26);
            Genero_Outro.TabIndex = 4;
            Genero_Outro.TabStop = true;
            Genero_Outro.Text = "Outro";
            Genero_Outro.UseVisualStyleBackColor = true;
            Genero_Outro.CheckedChanged += Genero_Outro_CheckedChanged;
            // 
            // Genero_Feminino
            // 
            Genero_Feminino.AutoSize = true;
            Genero_Feminino.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Genero_Feminino.Location = new Point(129, 16);
            Genero_Feminino.Name = "Genero_Feminino";
            Genero_Feminino.Size = new Size(109, 26);
            Genero_Feminino.TabIndex = 3;
            Genero_Feminino.TabStop = true;
            Genero_Feminino.Text = "Feminino";
            Genero_Feminino.UseVisualStyleBackColor = true;
            Genero_Feminino.CheckedChanged += Genero_Feminino_CheckedChanged;
            // 
            // Genero_Masculino
            // 
            Genero_Masculino.AutoSize = true;
            Genero_Masculino.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Genero_Masculino.Location = new Point(6, 16);
            Genero_Masculino.Name = "Genero_Masculino";
            Genero_Masculino.Size = new Size(117, 26);
            Genero_Masculino.TabIndex = 2;
            Genero_Masculino.TabStop = true;
            Genero_Masculino.Text = "Masculino";
            Genero_Masculino.UseVisualStyleBackColor = true;
            Genero_Masculino.CheckedChanged += Genero_Masculino_CheckedChanged;
            // 
            // Editar_Crianca
            // 
            Editar_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Editar_Crianca.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            Editar_Crianca.Location = new Point(245, 329);
            Editar_Crianca.Name = "Editar_Crianca";
            Editar_Crianca.Size = new Size(326, 88);
            Editar_Crianca.TabIndex = 20;
            Editar_Crianca.Text = "Editar Criança";
            Editar_Crianca.UseVisualStyleBackColor = false;
            Editar_Crianca.Click += Editar_Crianca_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(201, 39);
            label4.TabIndex = 19;
            label4.Text = "Bomzinho: ";
            // 
            // Nome_Crianca
            // 
            Nome_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Nome_Crianca.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            Nome_Crianca.Location = new Point(133, 81);
            Nome_Crianca.Name = "Nome_Crianca";
            Nome_Crianca.Size = new Size(500, 38);
            Nome_Crianca.TabIndex = 17;
            Nome_Crianca.TextChanged += Nome_Crianca_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(149, 39);
            label3.TabIndex = 16;
            label3.Text = "Genero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(128, 39);
            label2.TabIndex = 15;
            label2.Text = "Idade: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(135, 39);
            label1.TabIndex = 14;
            label1.Text = "Nome: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label5.Location = new Point(12, 24);
            label5.Name = "label5";
            label5.Size = new Size(64, 39);
            label5.TabIndex = 23;
            label5.Text = "ID:";
            // 
            // Idade_Crianca
            // 
            Idade_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Idade_Crianca.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            Idade_Crianca.Location = new Point(133, 142);
            Idade_Crianca.Name = "Idade_Crianca";
            Idade_Crianca.Size = new Size(61, 38);
            Idade_Crianca.TabIndex = 18;
            Idade_Crianca.TextChanged += Idade_Crianca_TextChanged;
            // 
            // Id_Crianca
            // 
            Id_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Id_Crianca.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            Id_Crianca.Location = new Point(79, 24);
            Id_Crianca.Name = "Id_Crianca";
            Id_Crianca.Size = new Size(61, 38);
            Id_Crianca.TabIndex = 1;
            Id_Crianca.TextChanged += Id_Crianca_TextChanged;
            // 
            // EditarCrianca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 146, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(Id_Crianca);
            Controls.Add(label5);
            Controls.Add(Bomzinho);
            Controls.Add(Generos);
            Controls.Add(Editar_Crianca);
            Controls.Add(label4);
            Controls.Add(Idade_Crianca);
            Controls.Add(Nome_Crianca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarCrianca";
            Text = "EditarCrianca";
            FormClosing += EditarCrianca_FormClosing;
            Bomzinho.ResumeLayout(false);
            Bomzinho.PerformLayout();
            Generos.ResumeLayout(false);
            Generos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Bomzinho;
        private RadioButton Bomzinho_False;
        private RadioButton Bomzinho_True;
        private GroupBox Generos;
        private RadioButton Genero_Outro;
        private RadioButton Genero_Feminino;
        private RadioButton Genero_Masculino;
        private Button Editar_Crianca;
        private Label label4;
        private TextBox Nome_Crianca;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox Idade_Crianca;
        private TextBox Id_Crianca;
    }
}