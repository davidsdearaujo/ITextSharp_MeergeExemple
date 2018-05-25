namespace MesclarPDF
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
            this.btnMesclar = new System.Windows.Forms.Button();
            this.txtPdf1 = new System.Windows.Forms.TextBox();
            this.txtPdf2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMesclar
            // 
            this.btnMesclar.Location = new System.Drawing.Point(283, 144);
            this.btnMesclar.Name = "btnMesclar";
            this.btnMesclar.Size = new System.Drawing.Size(75, 28);
            this.btnMesclar.TabIndex = 0;
            this.btnMesclar.Text = "Meerge!";
            this.btnMesclar.UseVisualStyleBackColor = true;
            this.btnMesclar.Click += new System.EventHandler(this.btnMesclar_Click);
            // 
            // txtPdf1
            // 
            this.txtPdf1.Location = new System.Drawing.Point(65, 23);
            this.txtPdf1.Name = "txtPdf1";
            this.txtPdf1.Size = new System.Drawing.Size(293, 20);
            this.txtPdf1.TabIndex = 1;
            this.txtPdf1.Text = "C:\\pdf test\\pdf1.pdf";
            // 
            // txtPdf2
            // 
            this.txtPdf2.Location = new System.Drawing.Point(65, 52);
            this.txtPdf2.Name = "txtPdf2";
            this.txtPdf2.Size = new System.Drawing.Size(293, 20);
            this.txtPdf2.TabIndex = 2;
            this.txtPdf2.Text = "C:\\pdf test\\pdf2.pdf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arquivo 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arquivo 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saída:";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(65, 111);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(293, 20);
            this.txtSaida.TabIndex = 5;
            this.txtSaida.Text = "C:\\pdf test\\pdf_out.pdf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPdf2);
            this.Controls.Add(this.txtPdf1);
            this.Controls.Add(this.btnMesclar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesclar;
        private System.Windows.Forms.TextBox txtPdf1;
        private System.Windows.Forms.TextBox txtPdf2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaida;
    }
}

