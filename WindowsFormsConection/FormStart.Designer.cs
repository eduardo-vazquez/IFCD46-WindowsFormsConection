namespace WindowsFormsConection
{
    partial class FormStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEJ01 = new System.Windows.Forms.Button();
            this.btnEJ02 = new System.Windows.Forms.Button();
            this.btnEJ03 = new System.Windows.Forms.Button();
            this.btnEJ04 = new System.Windows.Forms.Button();
            this.btnEJ05 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexión a Base de Datos";
            // 
            // btnEJ01
            // 
            this.btnEJ01.Location = new System.Drawing.Point(84, 127);
            this.btnEJ01.Name = "btnEJ01";
            this.btnEJ01.Size = new System.Drawing.Size(178, 36);
            this.btnEJ01.TabIndex = 1;
            this.btnEJ01.Text = "EJERCICIO 01";
            this.btnEJ01.UseVisualStyleBackColor = true;
            this.btnEJ01.Click += new System.EventHandler(this.btnEJ01_Click);
            // 
            // btnEJ02
            // 
            this.btnEJ02.Location = new System.Drawing.Point(84, 230);
            this.btnEJ02.Name = "btnEJ02";
            this.btnEJ02.Size = new System.Drawing.Size(178, 36);
            this.btnEJ02.TabIndex = 1;
            this.btnEJ02.Text = "EJERCICIO 02";
            this.btnEJ02.UseVisualStyleBackColor = true;
            this.btnEJ02.Click += new System.EventHandler(this.btnEJ02_Click);
            // 
            // btnEJ03
            // 
            this.btnEJ03.Location = new System.Drawing.Point(84, 350);
            this.btnEJ03.Name = "btnEJ03";
            this.btnEJ03.Size = new System.Drawing.Size(178, 36);
            this.btnEJ03.TabIndex = 1;
            this.btnEJ03.Text = "EJERCICIO 03";
            this.btnEJ03.UseVisualStyleBackColor = true;
            this.btnEJ03.Click += new System.EventHandler(this.btnEJ03_Click);
            // 
            // btnEJ04
            // 
            this.btnEJ04.Location = new System.Drawing.Point(370, 127);
            this.btnEJ04.Name = "btnEJ04";
            this.btnEJ04.Size = new System.Drawing.Size(178, 36);
            this.btnEJ04.TabIndex = 1;
            this.btnEJ04.Text = "EJERCICIO 04";
            this.btnEJ04.UseVisualStyleBackColor = true;
            this.btnEJ04.Click += new System.EventHandler(this.btnEJ04_Click);
            // 
            // btnEJ05
            // 
            this.btnEJ05.Location = new System.Drawing.Point(370, 230);
            this.btnEJ05.Name = "btnEJ05";
            this.btnEJ05.Size = new System.Drawing.Size(178, 36);
            this.btnEJ05.TabIndex = 1;
            this.btnEJ05.Text = "EJERCICIO 05";
            this.btnEJ05.UseVisualStyleBackColor = true;
            this.btnEJ05.Click += new System.EventHandler(this.btnEJ05_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "EJERCICIO 06";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEJ06_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arquitectura por capas / DAL";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEJ05);
            this.Controls.Add(this.btnEJ04);
            this.Controls.Add(this.btnEJ03);
            this.Controls.Add(this.btnEJ02);
            this.Controls.Add(this.btnEJ01);
            this.Controls.Add(this.label1);
            this.Name = "FormStart";
            this.Text = "Conexión a Base de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEJ01;
        private System.Windows.Forms.Button btnEJ02;
        private System.Windows.Forms.Button btnEJ03;
        private System.Windows.Forms.Button btnEJ04;
        private System.Windows.Forms.Button btnEJ05;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}