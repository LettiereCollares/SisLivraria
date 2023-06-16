namespace WinFormsApp1
{
    partial class emprestimo
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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            comboBoxLivros = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(59, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(59, 329);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(248, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 9);
            label2.Name = "label2";
            label2.Size = new Size(259, 25);
            label2.TabIndex = 5;
            label2.Text = "Solicitação de emprestimo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Livro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 311);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 7;
            label4.Text = "Final do empréstimo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 251);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 8;
            label5.Text = "Começo do emprestimo:";
            // 
            // button1
            // 
            button1.Location = new Point(119, 383);
            button1.Name = "button1";
            button1.Size = new Size(125, 25);
            button1.TabIndex = 9;
            button1.Text = "Realizar Empréstimo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxLivros
            // 
            comboBoxLivros.FormattingEnabled = true;
            comboBoxLivros.Location = new Point(59, 156);
            comboBoxLivros.Name = "comboBoxLivros";
            comboBoxLivros.Size = new Size(121, 23);
            comboBoxLivros.TabIndex = 10;
            // 
            // emprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 450);
            Controls.Add(comboBoxLivros);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "emprestimo";
            Text = "emprestimo";
            Load += emprestimo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ComboBox comboBoxLivros;
    }
}