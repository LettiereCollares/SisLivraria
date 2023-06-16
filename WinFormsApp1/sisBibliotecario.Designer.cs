namespace WinFormsApp1
{
    partial class sisBibliotecario
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fundolivraria;
            pictureBox1.Location = new Point(-60, -218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(974, 739);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(351, 124);
            button1.Name = "button1";
            button1.Size = new Size(118, 39);
            button1.TabIndex = 1;
            button1.Text = "Consultar arcervo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(147, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 29);
            label1.TabIndex = 2;
            label1.Text = "Seja bem vindo, Bibliotecário";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_biblioteca2;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(94, 124);
            button2.Name = "button2";
            button2.Size = new Size(118, 39);
            button2.TabIndex = 4;
            button2.Text = "Adicionar Livros";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(229, 260);
            button4.Name = "button4";
            button4.Size = new Size(118, 45);
            button4.TabIndex = 6;
            button4.Text = "Fazer emprestimo";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(520, 260);
            button5.Name = "button5";
            button5.Size = new Size(101, 45);
            button5.TabIndex = 7;
            button5.Text = "Solicitar devolução";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(785, -1);
            button6.Name = "button6";
            button6.Size = new Size(25, 33);
            button6.TabIndex = 8;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Crimson;
            linkLabel1.AllowDrop = true;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Pink;
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel1.Location = new Point(0, 81);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(136, 14);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Voltar para tela de login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(639, 118);
            button7.Name = "button7";
            button7.Size = new Size(118, 45);
            button7.TabIndex = 11;
            button7.Text = "Cadastrar usuário";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // sisBibliotecario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            CausesValidation = false;
            ClientSize = new Size(808, 403);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sisBibliotecario";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sisBibliotecario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button button7;
    }
}