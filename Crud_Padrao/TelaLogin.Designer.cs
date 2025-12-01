namespace Crud_Padrao
{
    partial class TelaLogin
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
            button1 = new Button();
            Senha_Text = new TextBox();
            Usuario_Text = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(228, 30, 24);
            button1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            button1.Location = new Point(350, 273);
            button1.Name = "button1";
            button1.Size = new Size(234, 61);
            button1.TabIndex = 9;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Senha_Text
            // 
            Senha_Text.BackColor = Color.FromArgb(228, 30, 24);
            Senha_Text.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Senha_Text.Location = new Point(311, 192);
            Senha_Text.Name = "Senha_Text";
            Senha_Text.Size = new Size(310, 47);
            Senha_Text.TabIndex = 8;
            Senha_Text.UseSystemPasswordChar = true;
            Senha_Text.TextChanged += Senha_Text_TextChanged;
            // 
            // Usuario_Text
            // 
            Usuario_Text.BackColor = Color.FromArgb(228, 30, 24);
            Usuario_Text.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario_Text.Location = new Point(311, 95);
            Usuario_Text.Name = "Usuario_Text";
            Usuario_Text.Size = new Size(310, 47);
            Usuario_Text.TabIndex = 7;
            Usuario_Text.TextChanged += Usuario_Text_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label2.Location = new Point(150, 195);
            label2.Name = "label2";
            label2.Size = new Size(142, 39);
            label2.TabIndex = 6;
            label2.Text = "Senha: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold);
            label1.Location = new Point(150, 98);
            label1.Name = "label1";
            label1.Size = new Size(155, 39);
            label1.TabIndex = 5;
            label1.Text = "Usuario:";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 146, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Senha_Text);
            Controls.Add(Usuario_Text);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaLogin";
            Text = "TelaLogin";
            FormClosing += TelaLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Senha_Text;
        private TextBox Usuario_Text;
        private Label label2;
        private Label label1;
    }
}