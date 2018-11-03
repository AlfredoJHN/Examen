namespace FrmConvertirMedidas
{
    partial class FrmConvertirMedidas
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
            this.lblNumeroPulgadas = new System.Windows.Forms.Label();
            this.lblNumeroCentimetros = new System.Windows.Forms.Label();
            this.tbPulgadas = new System.Windows.Forms.TextBox();
            this.tbCentimetros = new System.Windows.Forms.TextBox();
            this.btnConvertirPulgadasEnCentimetros = new System.Windows.Forms.Button();
            this.btnConvertirCentimetrosEnPulgadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroPulgadas
            // 
            this.lblNumeroPulgadas.AutoSize = true;
            this.lblNumeroPulgadas.Location = new System.Drawing.Point(110, 47);
            this.lblNumeroPulgadas.Name = "lblNumeroPulgadas";
            this.lblNumeroPulgadas.Size = new System.Drawing.Size(105, 13);
            this.lblNumeroPulgadas.TabIndex = 0;
            this.lblNumeroPulgadas.Text = "Número de pulgadas";
            // 
            // lblNumeroCentimetros
            // 
            this.lblNumeroCentimetros.AutoSize = true;
            this.lblNumeroCentimetros.Location = new System.Drawing.Point(97, 119);
            this.lblNumeroCentimetros.Name = "lblNumeroCentimetros";
            this.lblNumeroCentimetros.Size = new System.Drawing.Size(118, 13);
            this.lblNumeroCentimetros.TabIndex = 1;
            this.lblNumeroCentimetros.Text = "Número de centímetros";
            // 
            // tbPulgadas
            // 
            this.tbPulgadas.Location = new System.Drawing.Point(237, 47);
            this.tbPulgadas.Name = "tbPulgadas";
            this.tbPulgadas.Size = new System.Drawing.Size(100, 20);
            this.tbPulgadas.TabIndex = 2;
            // 
            // tbCentimetros
            // 
            this.tbCentimetros.Location = new System.Drawing.Point(237, 119);
            this.tbCentimetros.Name = "tbCentimetros";
            this.tbCentimetros.Size = new System.Drawing.Size(100, 20);
            this.tbCentimetros.TabIndex = 3;
            // 
            // btnConvertirPulgadasEnCentimetros
            // 
            this.btnConvertirPulgadasEnCentimetros.Location = new System.Drawing.Point(158, 183);
            this.btnConvertirPulgadasEnCentimetros.Name = "btnConvertirPulgadasEnCentimetros";
            this.btnConvertirPulgadasEnCentimetros.Size = new System.Drawing.Size(147, 23);
            this.btnConvertirPulgadasEnCentimetros.TabIndex = 4;
            this.btnConvertirPulgadasEnCentimetros.Text = "Convertir a centímetros";
            this.btnConvertirPulgadasEnCentimetros.UseVisualStyleBackColor = true;
            this.btnConvertirPulgadasEnCentimetros.Click += new System.EventHandler(this.btnConvertirPulgadasEnCentimetros_Click);
            // 
            // btnConvertirCentimetrosEnPulgadas
            // 
            this.btnConvertirCentimetrosEnPulgadas.Location = new System.Drawing.Point(158, 238);
            this.btnConvertirCentimetrosEnPulgadas.Name = "btnConvertirCentimetrosEnPulgadas";
            this.btnConvertirCentimetrosEnPulgadas.Size = new System.Drawing.Size(147, 23);
            this.btnConvertirCentimetrosEnPulgadas.TabIndex = 5;
            this.btnConvertirCentimetrosEnPulgadas.Text = "Convertir a pulgadas";
            this.btnConvertirCentimetrosEnPulgadas.UseVisualStyleBackColor = true;
            this.btnConvertirCentimetrosEnPulgadas.Click += new System.EventHandler(this.btnConvertirCentimetrosEnPulgadas_Click);
            // 
            // FrmConvertirMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 310);
            this.Controls.Add(this.btnConvertirCentimetrosEnPulgadas);
            this.Controls.Add(this.btnConvertirPulgadasEnCentimetros);
            this.Controls.Add(this.tbCentimetros);
            this.Controls.Add(this.tbPulgadas);
            this.Controls.Add(this.lblNumeroCentimetros);
            this.Controls.Add(this.lblNumeroPulgadas);
            this.Name = "FrmConvertirMedidas";
            this.Text = "FrmConvertirMedidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroPulgadas;
        private System.Windows.Forms.Label lblNumeroCentimetros;
        private System.Windows.Forms.TextBox tbPulgadas;
        private System.Windows.Forms.TextBox tbCentimetros;
        private System.Windows.Forms.Button btnConvertirPulgadasEnCentimetros;
        private System.Windows.Forms.Button btnConvertirCentimetrosEnPulgadas;
    }
}

