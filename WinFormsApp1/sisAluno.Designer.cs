namespace WinFormsApp1
{
    partial class sisAluno
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.fundolivraria;
            pictureBox1.Location = new Point(0, -100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_biblioteca2;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(142, 113);
            button1.Name = "button1";
            button1.Size = new Size(93, 41);
            button1.TabIndex = 4;
            button1.Text = "Consultar acervo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(360, 113);
            button3.Name = "button3";
            button3.Size = new Size(93, 41);
            button3.TabIndex = 6;
            button3.Text = "Pedir empréstimo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(606, 112);
            button4.Name = "button4";
            button4.Size = new Size(107, 42);
            button4.TabIndex = 7;
            button4.Text = "Solicitar devolução";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Crimson;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Crimson;
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel1.Location = new Point(12, 91);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 14);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Voltar para tela de login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(147, 8);
            label3.Name = "label3";
            label3.Size = new Size(249, 29);
            label3.TabIndex = 9;
            label3.Text = "Seja bem vindo, Aluno";
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(776, -1);
            button6.Name = "button6";
            button6.Size = new Size(25, 33);
            button6.TabIndex = 10;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // sisAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 347);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "sisAluno";
            Text = "sisAluno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button4;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button button6;
    }
}