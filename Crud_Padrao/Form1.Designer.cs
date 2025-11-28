namespace Crud_Padrao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cadastro = new Button();
            Login = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.BackColor = Color.FromArgb(228, 30, 24);
            Cadastro.Font = new Font("Vladimir Script", 26F, FontStyle.Bold);
            Cadastro.Location = new Point(273, 114);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(236, 82);
            Cadastro.TabIndex = 0;
            Cadastro.Text = "Fazer Cadastro";
            Cadastro.UseVisualStyleBackColor = false;
            Cadastro.Click += Cadastro_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(228, 30, 24);
            Login.Font = new Font("Vladimir Script", 26F, FontStyle.Bold);
            Login.Location = new Point(273, 250);
            Login.Name = "Login";
            Login.Size = new Size(236, 82);
            Login.TabIndex = 1;
            Login.Text = "Fazer Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arvore;
            pictureBox1.Location = new Point(525, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arvore;
            pictureBox2.Location = new Point(-5, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 331);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 146, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            Controls.Add(Cadastro);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Tela Inicial";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Cadastro;
        private Button Login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
