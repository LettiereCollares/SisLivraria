namespace WinFormsApp1
{
    partial class acervo
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
            dataGridViewLivros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLivros
            // 
            dataGridViewLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivros.Dock = DockStyle.Fill;
            dataGridViewLivros.Location = new Point(0, 0);
            dataGridViewLivros.Name = "dataGridViewLivros";
            dataGridViewLivros.RowTemplate.Height = 25;
            dataGridViewLivros.Size = new Size(808, 248);
            dataGridViewLivros.TabIndex = 0;
            // 
            // acervo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 248);
            Controls.Add(dataGridViewLivros);
            Name = "acervo";
            Text = "acervo";
            Load += acervo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLivros;
    }
}