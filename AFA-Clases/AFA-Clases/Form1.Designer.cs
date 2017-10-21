namespace AFA_Clases
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.btnAceptarDivision = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.cmbDivisionParaEquipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAceptarEquipo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbPosicionJugador = new System.Windows.Forms.ComboBox();
            this.cmbEquipoParaJugador = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudNumeroJugador = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDivisionParaJugador = new System.Windows.Forms.ComboBox();
            this.btnAceptarJugador = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEquipoConsultar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDivisionConsultar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNombreConsultar = new System.Windows.Forms.ComboBox();
            this.btnConsultarJugador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroJugador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese division:";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(102, 29);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(121, 20);
            this.txtDivision.TabIndex = 7;
            // 
            // btnAceptarDivision
            // 
            this.btnAceptarDivision.Location = new System.Drawing.Point(148, 60);
            this.btnAceptarDivision.Name = "btnAceptarDivision";
            this.btnAceptarDivision.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarDivision.TabIndex = 8;
            this.btnAceptarDivision.Text = "Aceptar";
            this.btnAceptarDivision.UseVisualStyleBackColor = true;
            this.btnAceptarDivision.Click += new System.EventHandler(this.btnAceptarDivision_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAceptarDivision);
            this.groupBox2.Controls.Add(this.txtDivision);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(34, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 101);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CARGAR DIVISION";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEquipo);
            this.groupBox3.Controls.Add(this.cmbDivisionParaEquipo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnAceptarEquipo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(34, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 127);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CARGAR EQUIPO";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(105, 59);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo.TabIndex = 15;
            // 
            // cmbDivisionParaEquipo
            // 
            this.cmbDivisionParaEquipo.FormattingEnabled = true;
            this.cmbDivisionParaEquipo.Location = new System.Drawing.Point(116, 29);
            this.cmbDivisionParaEquipo.Name = "cmbDivisionParaEquipo";
            this.cmbDivisionParaEquipo.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionParaEquipo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ingrese equipo:";
            // 
            // btnAceptarEquipo
            // 
            this.btnAceptarEquipo.Location = new System.Drawing.Point(162, 87);
            this.btnAceptarEquipo.Name = "btnAceptarEquipo";
            this.btnAceptarEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEquipo.TabIndex = 8;
            this.btnAceptarEquipo.Text = "Aceptar";
            this.btnAceptarEquipo.UseVisualStyleBackColor = true;
            this.btnAceptarEquipo.Click += new System.EventHandler(this.btnAceptarEquipo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seleccione division:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbPosicionJugador);
            this.groupBox4.Controls.Add(this.cmbEquipoParaJugador);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudNumeroJugador);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtNombreJugador);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmbDivisionParaJugador);
            this.groupBox4.Controls.Add(this.btnAceptarJugador);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(314, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 212);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CARGAR JUGADOR";
            // 
            // cmbPosicionJugador
            // 
            this.cmbPosicionJugador.AutoCompleteCustomSource.AddRange(new string[] {
            "Arquero",
            "Mediocampista",
            "Delantero",
            "Enganche"});
            this.cmbPosicionJugador.FormattingEnabled = true;
            this.cmbPosicionJugador.Items.AddRange(new object[] {
            "Arquero",
            "Delantero",
            "Defensor"});
            this.cmbPosicionJugador.Location = new System.Drawing.Point(107, 145);
            this.cmbPosicionJugador.Name = "cmbPosicionJugador";
            this.cmbPosicionJugador.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicionJugador.TabIndex = 17;
            // 
            // cmbEquipoParaJugador
            // 
            this.cmbEquipoParaJugador.FormattingEnabled = true;
            this.cmbEquipoParaJugador.Location = new System.Drawing.Point(121, 56);
            this.cmbEquipoParaJugador.Name = "cmbEquipoParaJugador";
            this.cmbEquipoParaJugador.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipoParaJugador.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Seleccione equipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ingrese posicion:";
            // 
            // nudNumeroJugador
            // 
            this.nudNumeroJugador.Location = new System.Drawing.Point(110, 120);
            this.nudNumeroJugador.Name = "nudNumeroJugador";
            this.nudNumeroJugador.Size = new System.Drawing.Size(51, 20);
            this.nudNumeroJugador.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ingrese numero:";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(110, 88);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJugador.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ingrese nombre:";
            // 
            // cmbDivisionParaJugador
            // 
            this.cmbDivisionParaJugador.FormattingEnabled = true;
            this.cmbDivisionParaJugador.Location = new System.Drawing.Point(121, 24);
            this.cmbDivisionParaJugador.Name = "cmbDivisionParaJugador";
            this.cmbDivisionParaJugador.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionParaJugador.TabIndex = 11;
            this.cmbDivisionParaJugador.SelectedIndexChanged += new System.EventHandler(this.cmbDivisionParaJugador_SelectedIndexChanged);
            // 
            // btnAceptarJugador
            // 
            this.btnAceptarJugador.Location = new System.Drawing.Point(167, 174);
            this.btnAceptarJugador.Name = "btnAceptarJugador";
            this.btnAceptarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarJugador.TabIndex = 8;
            this.btnAceptarJugador.Text = "Aceptar";
            this.btnAceptarJugador.UseVisualStyleBackColor = true;
            this.btnAceptarJugador.Click += new System.EventHandler(this.btnAceptarJugador_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Seleccione division:";
            // 
            // cmbEquipoConsultar
            // 
            this.cmbEquipoConsultar.FormattingEnabled = true;
            this.cmbEquipoConsultar.Location = new System.Drawing.Point(121, 66);
            this.cmbEquipoConsultar.Name = "cmbEquipoConsultar";
            this.cmbEquipoConsultar.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipoConsultar.TabIndex = 18;
            this.cmbEquipoConsultar.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoConsultar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione nombre:";
            // 
            // cmbDivisionConsultar
            // 
            this.cmbDivisionConsultar.FormattingEnabled = true;
            this.cmbDivisionConsultar.Location = new System.Drawing.Point(121, 34);
            this.cmbDivisionConsultar.Name = "cmbDivisionConsultar";
            this.cmbDivisionConsultar.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionConsultar.TabIndex = 15;
            this.cmbDivisionConsultar.SelectedIndexChanged += new System.EventHandler(this.cmbDivisionConsultar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleccione division:";
            // 
            // cmbNombreConsultar
            // 
            this.cmbNombreConsultar.FormattingEnabled = true;
            this.cmbNombreConsultar.Location = new System.Drawing.Point(121, 97);
            this.cmbNombreConsultar.Name = "cmbNombreConsultar";
            this.cmbNombreConsultar.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreConsultar.TabIndex = 19;
            // 
            // btnConsultarJugador
            // 
            this.btnConsultarJugador.Location = new System.Drawing.Point(216, 136);
            this.btnConsultarJugador.Name = "btnConsultarJugador";
            this.btnConsultarJugador.Size = new System.Drawing.Size(120, 23);
            this.btnConsultarJugador.TabIndex = 20;
            this.btnConsultarJugador.Text = "Consultar jugador";
            this.btnConsultarJugador.UseVisualStyleBackColor = true;
            this.btnConsultarJugador.Click += new System.EventHandler(this.btnConsultarJugador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnConsultarJugador);
            this.groupBox1.Controls.Add(this.cmbDivisionConsultar);
            this.groupBox1.Controls.Add(this.cmbNombreConsultar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEquipoConsultar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 174);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTAR JUGADOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AFA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroJugador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Button btnAceptarDivision;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbDivisionParaEquipo;
        private System.Windows.Forms.Button btnAceptarEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudNumeroJugador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDivisionParaJugador;
        private System.Windows.Forms.Button btnAceptarJugador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEquipoParaJugador;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPosicionJugador;
        private System.Windows.Forms.ComboBox cmbEquipoConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDivisionConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNombreConsultar;
        private System.Windows.Forms.Button btnConsultarJugador;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

