namespace FormsExercicio6
{
    partial class frmConversorDeMilhaParaKm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMilha = new System.Windows.Forms.Label();
            this.txtMilha = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(245, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de milha marítma para km";
            // 
            // lblMilha
            // 
            this.lblMilha.AutoSize = true;
            this.lblMilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilha.Location = new System.Drawing.Point(174, 73);
            this.lblMilha.Name = "lblMilha";
            this.lblMilha.Size = new System.Drawing.Size(107, 20);
            this.lblMilha.TabIndex = 1;
            this.lblMilha.Text = "Milha marítma";
            // 
            // txtMilha
            // 
            this.txtMilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilha.Location = new System.Drawing.Point(317, 73);
            this.txtMilha.Name = "txtMilha";
            this.txtMilha.Size = new System.Drawing.Size(316, 26);
            this.txtMilha.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(174, 106);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(313, 106);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(51, 20);
            this.lblKm.TabIndex = 4;
            this.lblKm.Text = "label4";
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(352, 157);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(92, 33);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.clickou_converter);
            // 
            // frmConversorDeMilhaParaKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtMilha);
            this.Controls.Add(this.lblMilha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmConversorDeMilhaParaKm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMilha;
        private System.Windows.Forms.TextBox txtMilha;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Button btnConverter;
    }
}

