namespace Catalogo_de_tipo_de_equipo
{
    partial class frmCrear
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblSelecciona = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.gbComponentes = new System.Windows.Forms.GroupBox();
            this.cbComponentes = new System.Windows.Forms.CheckBox();
            this.cbDisco = new System.Windows.Forms.CheckBox();
            this.cbMemoria = new System.Windows.Forms.CheckBox();
            this.cbCPU = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbComponentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 46);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(16, 76);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(44, 13);
            this.lblVida.TabIndex = 1;
            this.lblVida.Text = "Vida util";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(16, 106);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(106, 13);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duracion de garantia";
            // 
            // lblSelecciona
            // 
            this.lblSelecciona.AutoSize = true;
            this.lblSelecciona.Location = new System.Drawing.Point(12, 150);
            this.lblSelecciona.Name = "lblSelecciona";
            this.lblSelecciona.Size = new System.Drawing.Size(251, 13);
            this.lblSelecciona.TabIndex = 3;
            this.lblSelecciona.Text = "Selecciona los componentes para el tipo de equipo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(141, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(122, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtVida
            // 
            this.txtVida.Location = new System.Drawing.Point(141, 69);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(122, 20);
            this.txtVida.TabIndex = 5;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(141, 99);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(122, 20);
            this.txtDuracion.TabIndex = 6;
            // 
            // gbComponentes
            // 
            this.gbComponentes.Controls.Add(this.cbComponentes);
            this.gbComponentes.Controls.Add(this.cbDisco);
            this.gbComponentes.Controls.Add(this.cbMemoria);
            this.gbComponentes.Controls.Add(this.cbCPU);
            this.gbComponentes.Location = new System.Drawing.Point(19, 189);
            this.gbComponentes.Name = "gbComponentes";
            this.gbComponentes.Size = new System.Drawing.Size(169, 117);
            this.gbComponentes.TabIndex = 7;
            this.gbComponentes.TabStop = false;
            // 
            // cbComponentes
            // 
            this.cbComponentes.AutoSize = true;
            this.cbComponentes.Location = new System.Drawing.Point(14, 87);
            this.cbComponentes.Name = "cbComponentes";
            this.cbComponentes.Size = new System.Drawing.Size(141, 17);
            this.cbComponentes.TabIndex = 3;
            this.cbComponentes.Text = "... Componentes Activos";
            this.cbComponentes.UseVisualStyleBackColor = true;
            // 
            // cbDisco
            // 
            this.cbDisco.AutoSize = true;
            this.cbDisco.Location = new System.Drawing.Point(14, 64);
            this.cbDisco.Name = "cbDisco";
            this.cbDisco.Size = new System.Drawing.Size(79, 17);
            this.cbDisco.TabIndex = 2;
            this.cbDisco.Text = "Disco Duro";
            this.cbDisco.UseVisualStyleBackColor = true;
            // 
            // cbMemoria
            // 
            this.cbMemoria.AutoSize = true;
            this.cbMemoria.Location = new System.Drawing.Point(14, 41);
            this.cbMemoria.Name = "cbMemoria";
            this.cbMemoria.Size = new System.Drawing.Size(66, 17);
            this.cbMemoria.TabIndex = 1;
            this.cbMemoria.Text = "Memoria";
            this.cbMemoria.UseVisualStyleBackColor = true;
            // 
            // cbCPU
            // 
            this.cbCPU.AutoSize = true;
            this.cbCPU.Location = new System.Drawing.Point(14, 18);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(48, 17);
            this.cbCPU.TabIndex = 0;
            this.cbCPU.Text = "CPU";
            this.cbCPU.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Location = new System.Drawing.Point(19, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.Location = new System.Drawing.Point(100, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 370);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbComponentes);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblSelecciona);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmCrear";
            this.Text = "Crear";
            this.gbComponentes.ResumeLayout(false);
            this.gbComponentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblSelecciona;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtVida;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.GroupBox gbComponentes;
        private System.Windows.Forms.CheckBox cbComponentes;
        private System.Windows.Forms.CheckBox cbDisco;
        private System.Windows.Forms.CheckBox cbMemoria;
        private System.Windows.Forms.CheckBox cbCPU;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}