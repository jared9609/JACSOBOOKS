namespace Examen
{
    partial class frmVerCurso
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Curso 1\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Curso 2\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Curso 3\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Curso 4\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(12, 198);
            this.txtVer.Multiline = true;
            this.txtVer.Name = "txtVer";
            this.txtVer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVer.Size = new System.Drawing.Size(209, 92);
            this.txtVer.TabIndex = 4;
            // 
            // frmVerCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 312);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerCurso";
            this.Text = "Ver_Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtVer;
    }
}