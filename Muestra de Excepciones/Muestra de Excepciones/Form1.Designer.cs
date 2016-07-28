using System;

namespace Muestra_de_Excepciones
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIndice = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSobrecarga = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.Location = new System.Drawing.Point(118, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 53);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIndice
            // 
            this.btnIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIndice.Location = new System.Drawing.Point(42, 109);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(98, 53);
            this.btnIndice.TabIndex = 7;
            this.btnIndice.Text = "Indice fuera del rango";
            this.btnIndice.UseVisualStyleBackColor = false;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDivision.Location = new System.Drawing.Point(196, 25);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(98, 53);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "Division por cero";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSobrecarga
            // 
            this.btnSobrecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSobrecarga.Location = new System.Drawing.Point(42, 25);
            this.btnSobrecarga.Name = "btnSobrecarga";
            this.btnSobrecarga.Size = new System.Drawing.Size(98, 53);
            this.btnSobrecarga.TabIndex = 10;
            this.btnSobrecarga.Text = "Sobrecarga";
            this.btnSobrecarga.UseVisualStyleBackColor = false;
            this.btnSobrecarga.Click += new System.EventHandler(this.btnSobrecarga_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConversion.Location = new System.Drawing.Point(196, 109);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(98, 53);
            this.btnConversion.TabIndex = 11;
            this.btnConversion.Text = "Conversion de tipo";
            this.btnConversion.UseVisualStyleBackColor = false;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click_1);
            // 
            // frmMuestraExcepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Muestra_de_Excepciones.Properties.Resources.descarga__1_;
            this.ClientSize = new System.Drawing.Size(348, 273);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnSobrecarga);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnDivision);
            this.Name = "frmMuestraExcepciones";
            this.Text = "Muestra Excepciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSobrecarga;
        private System.Windows.Forms.Button btnConversion;
        private EventHandler btnConversion_Click;
    }
}

