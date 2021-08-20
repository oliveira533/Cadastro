namespace WindowsFormsApp1
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
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.btnGravarCategoria = new System.Windows.Forms.Button();
            this.btnGravarProd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(13, 48);
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(605, 311);
            this.grdDados.TabIndex = 0;
            this.grdDados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grdDados_KeyUp);
            // 
            // btnGravarCategoria
            // 
            this.btnGravarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarCategoria.Location = new System.Drawing.Point(13, 365);
            this.btnGravarCategoria.Name = "btnGravarCategoria";
            this.btnGravarCategoria.Size = new System.Drawing.Size(296, 60);
            this.btnGravarCategoria.TabIndex = 1;
            this.btnGravarCategoria.Text = "Gravar Categoria";
            this.btnGravarCategoria.UseVisualStyleBackColor = true;
            this.btnGravarCategoria.Click += new System.EventHandler(this.btnGravarCategoria_Click);
            // 
            // btnGravarProd
            // 
            this.btnGravarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarProd.Location = new System.Drawing.Point(322, 365);
            this.btnGravarProd.Name = "btnGravarProd";
            this.btnGravarProd.Size = new System.Drawing.Size(296, 60);
            this.btnGravarProd.TabIndex = 2;
            this.btnGravarProd.Text = "Gravar Produto";
            this.btnGravarProd.UseVisualStyleBackColor = true;
            this.btnGravarProd.Click += new System.EventHandler(this.btnGravarProd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gravar Unidade de Medida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(322, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGravarProd);
            this.Controls.Add(this.btnGravarCategoria);
            this.Controls.Add(this.grdDados);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.Button btnGravarCategoria;
        private System.Windows.Forms.Button btnGravarProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

