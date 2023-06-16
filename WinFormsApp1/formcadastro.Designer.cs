namespace WinFormsApp1
{
    partial class formcadastro
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
            text_nome = new TextBox();
            text_email = new TextBox();
            text_senha = new TextBox();
            text_senha2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txt_cel = new TextBox();
            txt_address = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            text_matri = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            label10 = new Label();
            checkSenha = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // text_nome
            // 
            text_nome.Location = new Point(53, 118);
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(204, 23);
            text_nome.TabIndex = 0;
            // 
            // text_email
            // 
            text_email.Location = new Point(53, 187);
            text_email.Name = "text_email";
            text_email.Size = new Size(204, 23);
            text_email.TabIndex = 1;
            text_email.TextChanged += textBox1_TextChanged;
            // 
            // text_senha
            // 
            text_senha.Location = new Point(53, 248);
            text_senha.Name = "text_senha";
            text_senha.Size = new Size(148, 23);
            text_senha.TabIndex = 2;
            text_senha.UseSystemPasswordChar = true;
            // 
            // text_senha2
            // 
            text_senha2.Location = new Point(53, 302);
            text_senha2.Name = "text_senha2";
            text_senha2.Size = new Size(148, 23);
            text_senha2.TabIndex = 3;
            text_senha2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(53, 98);
            label1.Name = "label1";
            label1.Size = new Size(74, 14);
            label1.TabIndex = 5;
            label1.Text = "Nome de Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(53, 163);
            label2.Name = "label2";
            label2.Size = new Size(30, 14);
            label2.TabIndex = 6;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(53, 223);
            label3.Name = "label3";
            label3.Size = new Size(32, 14);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(53, 285);
            label4.Name = "label4";
            label4.Size = new Size(74, 14);
            label4.TabIndex = 8;
            label4.Text = "Confirmar senha";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(558, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 9;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_cel
            // 
            txt_cel.Location = new Point(409, 98);
            txt_cel.Name = "txt_cel";
            txt_cel.Size = new Size(224, 23);
            txt_cel.TabIndex = 10;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(409, 160);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(224, 23);
            txt_address.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(111, 19);
            label5.Name = "label5";
            label5.Size = new Size(146, 39);
            label5.TabIndex = 13;
            label5.Text = "Cadastro";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(409, 80);
            label6.Name = "label6";
            label6.Size = new Size(37, 14);
            label6.TabIndex = 14;
            label6.Text = "Celular";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(409, 142);
            label7.Name = "label7";
            label7.Size = new Size(46, 14);
            label7.TabIndex = 15;
            label7.Text = "Endereço";
            // 
            // text_matri
            // 
            text_matri.Location = new Point(409, 214);
            text_matri.Name = "text_matri";
            text_matri.Size = new Size(106, 23);
            text_matri.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(408, 196);
            label8.Name = "label8";
            label8.Size = new Size(46, 14);
            label8.TabIndex = 17;
            label8.Text = "Matricula";
            label8.Click += label8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Professor", "Aluno", "Bibliotecario" });
            comboBox1.Location = new Point(521, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_biblioteca2;
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(521, 196);
            label9.Name = "label9";
            label9.Size = new Size(74, 14);
            label9.TabIndex = 20;
            label9.Text = "cadastrar como:";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(675, -3);
            button2.Name = "button2";
            button2.Size = new Size(31, 29);
            button2.TabIndex = 21;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel1.Location = new Point(409, 302);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 15);
            linkLabel1.TabIndex = 22;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Voltar para tela de login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.LightGray;
            label10.Location = new Point(423, 284);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 23;
            label10.Text = "Já possui conta?";
            // 
            // checkSenha
            // 
            checkSenha.AutoSize = true;
            checkSenha.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkSenha.ForeColor = Color.Crimson;
            checkSenha.Location = new Point(207, 307);
            checkSenha.Name = "checkSenha";
            checkSenha.Size = new Size(84, 18);
            checkSenha.TabIndex = 4;
            checkSenha.Text = "Mostrar senha";
            checkSenha.UseVisualStyleBackColor = true;
            checkSenha.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // formcadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(706, 394);
            Controls.Add(label10);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(text_matri);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_address);
            Controls.Add(txt_cel);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkSenha);
            Controls.Add(text_senha2);
            Controls.Add(text_senha);
            Controls.Add(text_email);
            Controls.Add(text_nome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formcadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formcadastro";
            Load += formcadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_nome;
        private TextBox text_email;
        private TextBox text_senha;
        private TextBox text_senha2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txt_cel;
        private TextBox txt_address;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox text_matri;
        private Label label8;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label10;
        private CheckBox checkSenha;
    }
}