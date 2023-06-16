namespace WinFormsApp1
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
            txt_senha = new TextBox();
            txt_email = new TextBox();
            txt1 = new Label();
            txt2 = new Label();
            checkBox1 = new CheckBox();
            button_send = new Button();
            linkcadastro = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(59, 208);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(144, 23);
            txt_senha.TabIndex = 0;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(59, 159);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "neymarjr@gmail.com";
            txt_email.Size = new Size(220, 23);
            txt_email.TabIndex = 1;
            txt_email.TextChanged += textBox2_TextChanged;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.ForeColor = Color.Crimson;
            txt1.Location = new Point(8, 162);
            txt1.Name = "txt1";
            txt1.Size = new Size(38, 14);
            txt1.TabIndex = 2;
            txt1.Text = "email:";
            txt1.Click += label1_Click;
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.ForeColor = Color.Crimson;
            txt2.Location = new Point(8, 208);
            txt2.Name = "txt2";
            txt2.Size = new Size(42, 14);
            txt2.TabIndex = 3;
            txt2.Text = "senha:";
            txt2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Crimson;
            checkBox1.Location = new Point(209, 212);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 18);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "exibir senha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button_send
            // 
            button_send.BackColor = Color.Crimson;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_send.ForeColor = Color.Black;
            button_send.Location = new Point(102, 297);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 33);
            button_send.TabIndex = 6;
            button_send.Text = "ENVIAR";
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button1_Click;
            // 
            // linkcadastro
            // 
            linkcadastro.AutoSize = true;
            linkcadastro.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkcadastro.ForeColor = Color.DarkSlateBlue;
            linkcadastro.LinkColor = Color.Crimson;
            linkcadastro.Location = new Point(117, 255);
            linkcadastro.Name = "linkcadastro";
            linkcadastro.Size = new Size(58, 14);
            linkcadastro.TabIndex = 7;
            linkcadastro.TabStop = true;
            linkcadastro.Text = "Cadastrar";
            linkcadastro.LinkClicked += linkcadastro_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.logo_biblioteca2;
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(117, 97);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 9;
            label1.Text = "LOG IN";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(294, 2);
            button1.Name = "button1";
            button1.Size = new Size(28, 32);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(322, 430);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(button_send);
            Controls.Add(linkcadastro);
            Controls.Add(txt_email);
            Controls.Add(txt_senha);
            Controls.Add(txt2);
            Controls.Add(txt1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca do rosa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private TextBox txt_senha;
        private TextBox txt_email;
        private Label txt1;
        private Label txt2;
        private CheckBox checkBox1;
        private Button button_send;
        private LinkLabel linkcadastro;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}