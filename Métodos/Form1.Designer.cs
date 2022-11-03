namespace Ex09Pag73
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
            this.lst = new System.Windows.Forms.ListBox();
            this.btngerar = new System.Windows.Forms.Button();
            this.btnmaior = new System.Windows.Forms.Button();
            this.lblmaior = new System.Windows.Forms.Label();
            this.btnmenor = new System.Windows.Forms.Button();
            this.lblmenor = new System.Windows.Forms.Label();
            this.btnmedia = new System.Windows.Forms.Button();
            this.lblmedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(37, 112);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(164, 173);
            this.lst.TabIndex = 0;
            // 
            // btngerar
            // 
            this.btngerar.Location = new System.Drawing.Point(55, 58);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(113, 32);
            this.btngerar.TabIndex = 1;
            this.btngerar.Text = "Gerar Numeros";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // btnmaior
            // 
            this.btnmaior.Location = new System.Drawing.Point(289, 63);
            this.btnmaior.Name = "btnmaior";
            this.btnmaior.Size = new System.Drawing.Size(75, 23);
            this.btnmaior.TabIndex = 2;
            this.btnmaior.Text = "maior";
            this.btnmaior.UseVisualStyleBackColor = true;
            this.btnmaior.Click += new System.EventHandler(this.btnmaior_Click);
            // 
            // lblmaior
            // 
            this.lblmaior.AutoSize = true;
            this.lblmaior.Location = new System.Drawing.Point(318, 121);
            this.lblmaior.Name = "lblmaior";
            this.lblmaior.Size = new System.Drawing.Size(13, 13);
            this.lblmaior.TabIndex = 3;
            this.lblmaior.Text = "0";
            // 
            // btnmenor
            // 
            this.btnmenor.Location = new System.Drawing.Point(420, 63);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(75, 23);
            this.btnmenor.TabIndex = 4;
            this.btnmenor.Text = "menor";
            this.btnmenor.UseVisualStyleBackColor = true;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // lblmenor
            // 
            this.lblmenor.AutoSize = true;
            this.lblmenor.Location = new System.Drawing.Point(449, 121);
            this.lblmenor.Name = "lblmenor";
            this.lblmenor.Size = new System.Drawing.Size(13, 13);
            this.lblmenor.TabIndex = 5;
            this.lblmenor.Text = "0";
            // 
            // btnmedia
            // 
            this.btnmedia.Location = new System.Drawing.Point(547, 63);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(75, 23);
            this.btnmedia.TabIndex = 6;
            this.btnmedia.Text = "media";
            this.btnmedia.UseVisualStyleBackColor = true;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Location = new System.Drawing.Point(573, 121);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(13, 13);
            this.lblmedia.TabIndex = 7;
            this.lblmedia.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.btnmedia);
            this.Controls.Add(this.lblmenor);
            this.Controls.Add(this.btnmenor);
            this.Controls.Add(this.lblmaior);
            this.Controls.Add(this.btnmaior);
            this.Controls.Add(this.btngerar);
            this.Controls.Add(this.lst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.Button btnmaior;
        private System.Windows.Forms.Label lblmaior;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Label lblmenor;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Label lblmedia;
    }
}

