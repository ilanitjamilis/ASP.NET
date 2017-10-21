namespace AFA_ListasDiccionarios
{
    partial class Form1
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
            this.rbtCargar = new System.Windows.Forms.RadioButton();
            this.rbtConsultar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtCargar
            // 
            this.rbtCargar.AutoSize = true;
            this.rbtCargar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCargar.Location = new System.Drawing.Point(225, 12);
            this.rbtCargar.Name = "rbtCargar";
            this.rbtCargar.Size = new System.Drawing.Size(79, 23);
            this.rbtCargar.TabIndex = 0;
            this.rbtCargar.TabStop = true;
            this.rbtCargar.Text = "Cargar";
            this.rbtCargar.UseVisualStyleBackColor = true;
            // 
            // rbtConsultar
            // 
            this.rbtConsultar.AutoSize = true;
            this.rbtConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtConsultar.Location = new System.Drawing.Point(323, 12);
            this.rbtConsultar.Name = "rbtConsultar";
            this.rbtConsultar.Size = new System.Drawing.Size(102, 23);
            this.rbtConsultar.TabIndex = 1;
            this.rbtConsultar.TabStop = true;
            this.rbtConsultar.Text = "Consultar";
            this.rbtConsultar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese división:";
            // 
            // txtDivision
            // 
            this.txtDivision.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivision.Location = new System.Drawing.Point(140, 50);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(34, 26);
            this.txtDivision.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese equipo:";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(140, 95);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(100, 26);
            this.txtEquipo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ïngrese deuda:";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.Location = new System.Drawing.Point(140, 138);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 26);
            this.txtDeuda.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(288, 138);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 42);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 196);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtConsultar);
            this.Controls.Add(this.rbtCargar);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AFA deudas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtCargar;
        private System.Windows.Forms.RadioButton rbtConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Button btnAceptar;
    }
}

