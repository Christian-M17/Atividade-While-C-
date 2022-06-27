namespace AtividadeWhile
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMultiplo3 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiplo3
            // 
            this.btnMultiplo3.Location = new System.Drawing.Point(85, 75);
            this.btnMultiplo3.Name = "btnMultiplo3";
            this.btnMultiplo3.Size = new System.Drawing.Size(151, 23);
            this.btnMultiplo3.TabIndex = 0;
            this.btnMultiplo3.Text = "Multiplos de 3";
            this.btnMultiplo3.UseVisualStyleBackColor = true;
            this.btnMultiplo3.Click += new System.EventHandler(this.btnMultiplo3_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(85, 134);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(151, 23);
            this.btn100.TabIndex = 1;
            this.btn100.Text = "100 a 1000";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(85, 194);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(151, 23);
            this.btnAlunos.TabIndex = 2;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 435);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btnMultiplo3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMultiplo3;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btnAlunos;
    }
}

