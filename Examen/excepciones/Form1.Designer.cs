namespace excepciones
{
    partial class frmMuestraExcepciones
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
            this.btnSobrecarga = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnIndice = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSobrecarga
            // 
            this.btnSobrecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSobrecarga.Location = new System.Drawing.Point(28, 27);
            this.btnSobrecarga.Name = "btnSobrecarga";
            this.btnSobrecarga.Size = new System.Drawing.Size(98, 53);
            this.btnSobrecarga.TabIndex = 0;
            this.btnSobrecarga.Text = "Sobrecarga";
            this.btnSobrecarga.UseVisualStyleBackColor = false;
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDivision.Location = new System.Drawing.Point(182, 26);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(98, 53);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.Text = "Division por cero";
            this.btnDivision.UseVisualStyleBackColor = false;
            // 
            // btnIndice
            // 
            this.btnIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIndice.Location = new System.Drawing.Point(28, 110);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(98, 53);
            this.btnIndice.TabIndex = 2;
            this.btnIndice.Text = "Indice fuera del rango";
            this.btnIndice.UseVisualStyleBackColor = false;
            // 
            // btnConversion
            // 
            this.btnConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConversion.Location = new System.Drawing.Point(182, 110);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(98, 53);
            this.btnConversion.TabIndex = 3;
            this.btnConversion.Text = "Conversion de tipo";
            this.btnConversion.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.Location = new System.Drawing.Point(104, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 53);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMuestraExcepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::excepciones.Properties.Resources.descarga__1_;
            this.ClientSize = new System.Drawing.Size(304, 283);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSobrecarga);
            this.Name = "frmMuestraExcepciones";
            this.Text = "Muestra Excepciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSobrecarga;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Button btnSalir;
    }
}

