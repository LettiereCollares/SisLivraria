namespace WinFormsApp1
{
    partial class sisProf
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.fundolivraria;
            pictureBox1.Location = new Point(-6, -74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 478);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = Properties.Resources.logo_biblioteca2;
            pictureBox2.Location = new Point(-6, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Crimson;
            linkLabel1.AllowDrop = true;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Crimson;
            linkLabel1.LinkColor = Color.Crimson;
            linkLabel1.Location = new Point(12, 91);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(136, 14);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Voltar para tela de login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(125, 126);
            button1.Name = "button1";
            button1.Size = new Size(118, 39);
            button1.TabIndex = 11;
            button1.Text = "Consultar arcervo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(347, 126);
            button3.Name = "button3";
            button3.Size = new Size(109, 42);
            button3.TabIndex = 13;
            button3.Text = "Pedir empréstimo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(585, 124);
            button4.Name = "button4";
            button4.Size = new Size(107, 42);
            button4.TabIndex = 14;
            button4.Text = "Solicitar devolução";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 29);
            label1.TabIndex = 15;
            label1.Text = "Seja bem vindo, Professor";
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(777, 0);
            button6.Name = "button6";
            button6.Size = new Size(25, 33);
            button6.TabIndex = 16;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // sisProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sisProf";
            Text = "sisProf";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button6;
    }
}