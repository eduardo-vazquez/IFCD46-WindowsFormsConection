namespace WindowsFormsConection
{
    partial class FormLINQ
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
            this.dgvTablaJobs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaxSalary = new System.Windows.Forms.TextBox();
            this.tbxMinSalary = new System.Windows.Forms.TextBox();
            this.tbxJobTitle = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizarDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaJobs
            // 
            this.dgvTablaJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaJobs.Location = new System.Drawing.Point(355, 78);
            this.dgvTablaJobs.Name = "dgvTablaJobs";
            this.dgvTablaJobs.Size = new System.Drawing.Size(487, 385);
            this.dgvTablaJobs.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Max Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Min Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "TABLA DE JOBS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Job Title";
            // 
            // tbxMaxSalary
            // 
            this.tbxMaxSalary.Location = new System.Drawing.Point(82, 127);
            this.tbxMaxSalary.Name = "tbxMaxSalary";
            this.tbxMaxSalary.Size = new System.Drawing.Size(218, 20);
            this.tbxMaxSalary.TabIndex = 48;
            // 
            // tbxMinSalary
            // 
            this.tbxMinSalary.Location = new System.Drawing.Point(82, 101);
            this.tbxMinSalary.Name = "tbxMinSalary";
            this.tbxMinSalary.Size = new System.Drawing.Size(218, 20);
            this.tbxMinSalary.TabIndex = 49;
            // 
            // tbxJobTitle
            // 
            this.tbxJobTitle.Location = new System.Drawing.Point(82, 75);
            this.tbxJobTitle.Name = "tbxJobTitle";
            this.tbxJobTitle.Size = new System.Drawing.Size(218, 20);
            this.tbxJobTitle.TabIndex = 50;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(11, 161);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(289, 39);
            this.btnInsertar.TabIndex = 47;
            this.btnInsertar.Text = "Insertar Datos";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "NUEVO REGISTRO";
            // 
            // btnActualizarDGV
            // 
            this.btnActualizarDGV.Location = new System.Drawing.Point(711, 485);
            this.btnActualizarDGV.Name = "btnActualizarDGV";
            this.btnActualizarDGV.Size = new System.Drawing.Size(131, 27);
            this.btnActualizarDGV.TabIndex = 47;
            this.btnActualizarDGV.Text = "Actualizar Datos";
            this.btnActualizarDGV.UseVisualStyleBackColor = true;
            this.btnActualizarDGV.Click += new System.EventHandler(this.btnActualizarDGV_Click);
            // 
            // FormLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 541);
            this.Controls.Add(this.dgvTablaJobs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMaxSalary);
            this.Controls.Add(this.tbxMinSalary);
            this.Controls.Add(this.tbxJobTitle);
            this.Controls.Add(this.btnActualizarDGV);
            this.Controls.Add(this.btnInsertar);
            this.Name = "FormLINQ";
            this.Text = "LINQ";
            this.Load += new System.EventHandler(this.CargarJobsEnGrid);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaJobs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaxSalary;
        private System.Windows.Forms.TextBox tbxMinSalary;
        private System.Windows.Forms.TextBox tbxJobTitle;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizarDGV;
    }
}