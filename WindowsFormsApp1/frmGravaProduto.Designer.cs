namespace WindowsFormsApp1
{
    partial class frmGravaProduto
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSubTitulo = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmCategoria = new System.Windows.Forms.ComboBox();
            this.cbmUniMed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txbPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(12, 25);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(206, 38);
            this.txbNome.TabIndex = 1;
            // 
            // txbSubTitulo
            // 
            this.txbSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubTitulo.Location = new System.Drawing.Point(237, 25);
            this.txbSubTitulo.Name = "txbSubTitulo";
            this.txbSubTitulo.Size = new System.Drawing.Size(206, 38);
            this.txbSubTitulo.TabIndex = 3;
            // 
            // txbDesc
            // 
            this.txbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesc.Location = new System.Drawing.Point(12, 83);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(431, 120);
            this.txbDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SubTitulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrição";
            // 
            // cbmCategoria
            // 
            this.cbmCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmCategoria.FormattingEnabled = true;
            this.cbmCategoria.Location = new System.Drawing.Point(237, 220);
            this.cbmCategoria.Name = "cbmCategoria";
            this.cbmCategoria.Size = new System.Drawing.Size(207, 39);
            this.cbmCategoria.TabIndex = 7;
            // 
            // cbmUniMed
            // 
            this.cbmUniMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmUniMed.FormattingEnabled = true;
            this.cbmUniMed.Location = new System.Drawing.Point(13, 220);
            this.cbmUniMed.Name = "cbmUniMed";
            this.cbmUniMed.Size = new System.Drawing.Size(207, 39);
            this.cbmUniMed.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidade de Medida";
            // 
            // txbPreco
            // 
            this.txbPreco.DecimalPlaces = 2;
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(11, 283);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(433, 38);
            this.txbPreco.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço";
            // 
            // btnInsere
            // 
            this.btnInsere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsere.Location = new System.Drawing.Point(11, 344);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(433, 31);
            this.btnInsere.TabIndex = 13;
            this.btnInsere.Text = "inserir";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // frmGravaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 390);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmUniMed);
            this.Controls.Add(this.cbmCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbSubTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNome);
            this.Name = "frmGravaProduto";
            this.Text = "frmGravaProduto";
            this.Load += new System.EventHandler(this.frmGravaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSubTitulo;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmCategoria;
        private System.Windows.Forms.ComboBox cbmUniMed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txbPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsere;
    }
}