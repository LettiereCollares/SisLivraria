namespace WinFormsApp1
{
    partial class Addlivros
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
            txt_livro = new TextBox();
            txt_autor = new TextBox();
            box_categoria = new ComboBox();
            box_faixa = new ComboBox();
            box_plataforma = new ComboBox();
            txt_ano = new TextBox();
            txt_sinopse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_livro
            // 
            txt_livro.Location = new Point(87, 22);
            txt_livro.Name = "txt_livro";
            txt_livro.Size = new Size(204, 23);
            txt_livro.TabIndex = 0;
            // 
            // txt_autor
            // 
            txt_autor.Location = new Point(87, 63);
            txt_autor.Name = "txt_autor";
            txt_autor.Size = new Size(204, 23);
            txt_autor.TabIndex = 1;
            // 
            // box_categoria
            // 
            box_categoria.FormattingEnabled = true;
            box_categoria.Items.AddRange(new object[] { "", "Fantasia", "Ficção científica", "Distopia", "Ação e aventura", "Ficção Policial", "Horror", "Thriller e Suspense", "Ficção histórica", "Romance", "Novela", "Ficção Feminina", "LGBTQ+", "Ficção Contemporânea", "Realismo mágico", "Graphic Novel", "Conto", "Young adult – Jovem adulto", "New adult – Novo Adulto ", "Infantil", "Memórias e autobiografia", "Biografia", "Gastronomia", "Arte e Fotografia", "Autoajuda", "História", "Viagem", "Crimes Reais", "Humor", "Ensaios", "Guias & Como fazer ", "Religião e Espiritualidade", "Humanidades e Ciências Sociais", "Paternidade e família", "Tecnologia e Ciência" });
            box_categoria.Location = new Point(87, 92);
            box_categoria.Name = "box_categoria";
            box_categoria.Size = new Size(161, 23);
            box_categoria.TabIndex = 2;
            // 
            // box_faixa
            // 
            box_faixa.FormattingEnabled = true;
            box_faixa.Items.AddRange(new object[] { "0-3", "4-5", "6-7", "8-9", "10-11", "12+" });
            box_faixa.Location = new Point(87, 121);
            box_faixa.Name = "box_faixa";
            box_faixa.Size = new Size(33, 23);
            box_faixa.TabIndex = 3;
            // 
            // box_plataforma
            // 
            box_plataforma.FormattingEnabled = true;
            box_plataforma.Items.AddRange(new object[] { "Livro Físico", "Ebook" });
            box_plataforma.Location = new Point(87, 150);
            box_plataforma.Name = "box_plataforma";
            box_plataforma.Size = new Size(115, 23);
            box_plataforma.TabIndex = 4;
            // 
            // txt_ano
            // 
            txt_ano.Location = new Point(87, 187);
            txt_ano.Name = "txt_ano";
            txt_ano.Size = new Size(62, 23);
            txt_ano.TabIndex = 5;
            // 
            // txt_sinopse
            // 
            txt_sinopse.Location = new Point(87, 232);
            txt_sinopse.Multiline = true;
            txt_sinopse.Name = "txt_sinopse";
            txt_sinopse.Size = new Size(192, 127);
            txt_sinopse.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Livro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 100);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 10;
            label4.Text = "Faixa Etária:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 11;
            label5.Text = "Plataforma:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 190);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 12;
            label6.Text = "Ano:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 235);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Sinopse:";
            // 
            // button1
            // 
            button1.Location = new Point(216, 373);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addlivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 408);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_sinopse);
            Controls.Add(txt_ano);
            Controls.Add(box_plataforma);
            Controls.Add(box_faixa);
            Controls.Add(box_categoria);
            Controls.Add(txt_autor);
            Controls.Add(txt_livro);
            Name = "Addlivros";
            Text = "Addlivros";
            Load += Addlivros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_livro;
        private TextBox txt_autor;
        private ComboBox box_categoria;
        private ComboBox box_faixa;
        private ComboBox box_plataforma;
        private TextBox txt_ano;
        private TextBox txt_sinopse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}