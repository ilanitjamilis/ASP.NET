namespace Repaso
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
            this.txtVerNumerico = new System.Windows.Forms.TextBox();
            this.btnVerNumerico = new System.Windows.Forms.Button();
            this.txtAceptarOrdenar = new System.Windows.Forms.TextBox();
            this.btnAceptarOrdenar = new System.Windows.Forms.Button();
            this.txtTextoLargo = new System.Windows.Forms.TextBox();
            this.btnTextoLargo = new System.Windows.Forms.Button();
            this.nudNota1 = new System.Windows.Forms.NumericUpDown();
            this.nudNota2 = new System.Windows.Forms.NumericUpDown();
            this.nudNota3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAprobo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVerNumerico
            // 
            this.txtVerNumerico.Location = new System.Drawing.Point(12, 31);
            this.txtVerNumerico.Name = "txtVerNumerico";
            this.txtVerNumerico.Size = new System.Drawing.Size(100, 20);
            this.txtVerNumerico.TabIndex = 0;
            this.txtVerNumerico.TextChanged += new System.EventHandler(this.txtVerNumerico_TextChanged);
            // 
            // btnVerNumerico
            // 
            this.btnVerNumerico.Location = new System.Drawing.Point(12, 57);
            this.btnVerNumerico.Name = "btnVerNumerico";
            this.btnVerNumerico.Size = new System.Drawing.Size(116, 23);
            this.btnVerNumerico.TabIndex = 1;
            this.btnVerNumerico.Text = "Ver si es numérico";
            this.btnVerNumerico.UseVisualStyleBackColor = true;
            this.btnVerNumerico.Click += new System.EventHandler(this.btnVerNumerico_Click);
            // 
            // txtAceptarOrdenar
            // 
            this.txtAceptarOrdenar.Location = new System.Drawing.Point(12, 132);
            this.txtAceptarOrdenar.Name = "txtAceptarOrdenar";
            this.txtAceptarOrdenar.Size = new System.Drawing.Size(100, 20);
            this.txtAceptarOrdenar.TabIndex = 2;
            // 
            // btnAceptarOrdenar
            // 
            this.btnAceptarOrdenar.Location = new System.Drawing.Point(12, 158);
            this.btnAceptarOrdenar.Name = "btnAceptarOrdenar";
            this.btnAceptarOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarOrdenar.TabIndex = 3;
            this.btnAceptarOrdenar.Text = "Aceptar";
            this.btnAceptarOrdenar.UseVisualStyleBackColor = true;
            this.btnAceptarOrdenar.Click += new System.EventHandler(this.btnAceptarOrdenar_Click);
            // 
            // txtTextoLargo
            // 
            this.txtTextoLargo.Location = new System.Drawing.Point(12, 236);
            this.txtTextoLargo.Name = "txtTextoLargo";
            this.txtTextoLargo.Size = new System.Drawing.Size(216, 20);
            this.txtTextoLargo.TabIndex = 4;
            // 
            // btnTextoLargo
            // 
            this.btnTextoLargo.Location = new System.Drawing.Point(15, 262);
            this.btnTextoLargo.Name = "btnTextoLargo";
            this.btnTextoLargo.Size = new System.Drawing.Size(75, 23);
            this.btnTextoLargo.TabIndex = 5;
            this.btnTextoLargo.Text = "Aceptar";
            this.btnTextoLargo.UseVisualStyleBackColor = true;
            this.btnTextoLargo.Click += new System.EventHandler(this.btnTextoLargo_Click);
            // 
            // nudNota1
            // 
            this.nudNota1.Location = new System.Drawing.Point(15, 358);
            this.nudNota1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNota1.Name = "nudNota1";
            this.nudNota1.Size = new System.Drawing.Size(49, 20);
            this.nudNota1.TabIndex = 6;
            this.nudNota1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNota2
            // 
            this.nudNota2.Location = new System.Drawing.Point(109, 358);
            this.nudNota2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNota2.Name = "nudNota2";
            this.nudNota2.Size = new System.Drawing.Size(49, 20);
            this.nudNota2.TabIndex = 7;
            this.nudNota2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNota3
            // 
            this.nudNota3.Location = new System.Drawing.Point(228, 358);
            this.nudNota3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNota3.Name = "nudNota3";
            this.nudNota3.Size = new System.Drawing.Size(49, 20);
            this.nudNota3.TabIndex = 8;
            this.nudNota3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nota 3";
            // 
            // btnAprobo
            // 
            this.btnAprobo.Location = new System.Drawing.Point(326, 344);
            this.btnAprobo.Name = "btnAprobo";
            this.btnAprobo.Size = new System.Drawing.Size(75, 44);
            this.btnAprobo.TabIndex = 12;
            this.btnAprobo.Text = "Ver si aprobó";
            this.btnAprobo.UseVisualStyleBackColor = true;
            this.btnAprobo.Click += new System.EventHandler(this.btnAprobo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingresar un valor en un textbox y me diga si es numérico o no.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingresar 10 numero por teclado. Crear una funcion que los ordene de forma ascende" +
    "nte y muestre. VALIDAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ingresar 10 textos por teclado. Mostrar que texto ingresado es el más largo (con " +
    "funcion).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(580, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ingresar la nota de 3 trimestres (por combo box o number picker cada una) y decir" +
    " si el alumno aprobó o no. (con funcion).";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 397);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAprobo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNota3);
            this.Controls.Add(this.nudNota2);
            this.Controls.Add(this.nudNota1);
            this.Controls.Add(this.btnTextoLargo);
            this.Controls.Add(this.txtTextoLargo);
            this.Controls.Add(this.btnAceptarOrdenar);
            this.Controls.Add(this.txtAceptarOrdenar);
            this.Controls.Add(this.btnVerNumerico);
            this.Controls.Add(this.txtVerNumerico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "REPASO";
            ((System.ComponentModel.ISupportInitialize)(this.nudNota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVerNumerico;
        private System.Windows.Forms.Button btnVerNumerico;
        private System.Windows.Forms.TextBox txtAceptarOrdenar;
        private System.Windows.Forms.Button btnAceptarOrdenar;
        private System.Windows.Forms.TextBox txtTextoLargo;
        private System.Windows.Forms.Button btnTextoLargo;
        private System.Windows.Forms.NumericUpDown nudNota1;
        private System.Windows.Forms.NumericUpDown nudNota2;
        private System.Windows.Forms.NumericUpDown nudNota3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAprobo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

