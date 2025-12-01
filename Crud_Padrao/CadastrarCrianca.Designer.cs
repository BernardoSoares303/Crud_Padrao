namespace Crud_Padrao
{
    partial class CadastrarCrianca
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
            Bomzinho_True = new RadioButton();
            Bomzinho_False = new RadioButton();
            Genero_Masculino = new RadioButton();
            Genero_Feminino = new RadioButton();
            Genero_Outro = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            Cadastrar_Crianca = new Button();
            Generos = new GroupBox();
            Bomzinho = new GroupBox();
            Generos.SuspendLayout();
            Bomzinho.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label1.Location = new Point(5, 27);
            label1.Name = "label1";
            label1.Size = new Size(135, 39);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label2.Location = new Point(5, 87);
            label2.Name = "label2";
            label2.Size = new Size(128, 39);
            label2.TabIndex = 1;
            label2.Text = "Idade: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label3.Location = new Point(5, 151);
            label3.Name = "label3";
            label3.Size = new Size(149, 39);
            label3.TabIndex = 2;
            label3.Text = "Genero:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(228, 30, 24);
            textBox1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            textBox1.Location = new Point(126, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 38);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(228, 30, 24);
            textBox2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            textBox2.Location = new Point(126, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 38);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label4.Location = new Point(5, 210);
            label4.Name = "label4";
            label4.Size = new Size(201, 39);
            label4.TabIndex = 8;
            label4.Text = "Bomzinho: ";
            // 
            // Cadastrar_Crianca
            // 
            Cadastrar_Crianca.BackColor = Color.FromArgb(228, 30, 24);
            Cadastrar_Crianca.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            Cadastrar_Crianca.Location = new Point(221, 317);
            Cadastrar_Crianca.Name = "Cadastrar_Crianca";
            Cadastrar_Crianca.Size = new Size(326, 88);
            Cadastrar_Crianca.TabIndex = 11;
            Cadastrar_Crianca.Text = "Cadastrar Crinça";
            Cadastrar_Crianca.UseVisualStyleBackColor = false;
            Cadastrar_Crianca.Click += Cadastrar_Crianca_Click;
            // 
            // Generos
            // 
            Generos.Controls.Add(Genero_Outro);
            Generos.Controls.Add(Genero_Feminino);
            Generos.Controls.Add(Genero_Masculino);
            Generos.Location = new Point(160, 142);
            Generos.Name = "Generos";
            Generos.Size = new Size(327, 48);
            Generos.TabIndex = 12;
            Generos.TabStop = false;
            // 
            // Bomzinho
            // 
            Bomzinho.Controls.Add(Bomzinho_False);
            Bomzinho.Controls.Add(Bomzinho_True);
            Bomzinho.Location = new Point(200, 204);
            Bomzinho.Name = "Bomzinho";
            Bomzinho.Size = new Size(161, 48);
            Bomzinho.TabIndex = 13;
            Bomzinho.TabStop = false;
            // 
            // CadastrarCrianca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 146, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(Bomzinho);
            Controls.Add(Generos);
            Controls.Add(Cadastrar_Crianca);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarCrianca";
            Text = "CadastrarCrianca";
            FormClosing += CadastrarCrianca_FormClosing;
            Generos.ResumeLayout(false);
            Generos.PerformLayout();
            Bomzinho.ResumeLayout(false);
            Bomzinho.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button Cadastrar_Crianca;
        private GroupBox Generos;
        private GroupBox Bomzinho;
        private RadioButton Bomzinho_True;
        private RadioButton Bomzinho_False;
        private RadioButton Genero_Masculino;
        private RadioButton Genero_Feminino;
        private RadioButton Genero_Outro;
    }
}