namespace IneqWinFormAPP
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlpCredenciales = new System.Windows.Forms.TableLayoutPanel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpCredenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.ColumnCount = 2;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLayout.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpLayout.Controls.Add(this.tlpLogin, 1, 0);
            this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 1;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLayout.Size = new System.Drawing.Size(784, 561);
            this.tlpLayout.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 1;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogin.Controls.Add(this.pbLogo, 0, 0);
            this.tlpLogin.Controls.Add(this.tlpCredenciales, 0, 1);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(395, 3);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 2;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.63039F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.36961F));
            this.tlpLogin.Size = new System.Drawing.Size(386, 555);
            this.tlpLogin.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(380, 158);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tlpCredenciales
            // 
            this.tlpCredenciales.ColumnCount = 1;
            this.tlpCredenciales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCredenciales.Controls.Add(this.btnIngresar, 0, 2);
            this.tlpCredenciales.Controls.Add(this.textBox2, 0, 1);
            this.tlpCredenciales.Controls.Add(this.label1, 0, 0);
            this.tlpCredenciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCredenciales.Location = new System.Drawing.Point(3, 167);
            this.tlpCredenciales.Name = "tlpCredenciales";
            this.tlpCredenciales.RowCount = 3;
            this.tlpCredenciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCredenciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCredenciales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCredenciales.Size = new System.Drawing.Size(380, 385);
            this.tlpCredenciales.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(3, 325);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(374, 57);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar Sesion";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlpLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de inventario de equipos";
            this.tlpLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpCredenciales.ResumeLayout(false);
            this.tlpCredenciales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpCredenciales;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

