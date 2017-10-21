namespace AlumnosORT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresarAlumno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrientacion = new System.Windows.Forms.ComboBox();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listaAlumnos = new System.Windows.Forms.ListBox();
            this.btnPasoDeAño = new System.Windows.Forms.Button();
            this.btnCambioOrientacion = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnIngresarAlumno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbOrientacion);
            this.groupBox1.Controls.Add(this.nudAño);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 392);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar alumno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "(alumnos menores de 4to año ciclo básico)";
            // 
            // btnIngresarAlumno
            // 
            this.btnIngresarAlumno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAlumno.Location = new System.Drawing.Point(227, 337);
            this.btnIngresarAlumno.Name = "btnIngresarAlumno";
            this.btnIngresarAlumno.Size = new System.Drawing.Size(106, 39);
            this.btnIngresarAlumno.TabIndex = 9;
            this.btnIngresarAlumno.Text = "Aceptar";
            this.btnIngresarAlumno.UseVisualStyleBackColor = true;
            this.btnIngresarAlumno.Click += new System.EventHandler(this.btnIngresarAlumno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Orientacion";
            // 
            // cmbOrientacion
            // 
            this.cmbOrientacion.FormattingEnabled = true;
            this.cmbOrientacion.Items.AddRange(new object[] {
            "Ciclo Básico",
            "Construcciones",
            "Diseño Industrial",
            "Electrónica",
            "Gestión Administrativa",
            "Informática y Medios de Comunicación Digitales",
            "Producción de Medios de Comunicación",
            "Producción Musical",
            "Química",
            "Tecnología de Información y Comunicación"});
            this.cmbOrientacion.Location = new System.Drawing.Point(27, 284);
            this.cmbOrientacion.Name = "cmbOrientacion";
            this.cmbOrientacion.Size = new System.Drawing.Size(288, 28);
            this.cmbOrientacion.TabIndex = 7;
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(27, 211);
            this.nudAño.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(43, 25);
            this.nudAño.TabIndex = 6;
            this.nudAño.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(27, 138);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 25);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 25);
            this.txtNombre.TabIndex = 4;
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAlumnos.FormattingEnabled = true;
            this.listaAlumnos.ItemHeight = 20;
            this.listaAlumnos.Location = new System.Drawing.Point(9, 21);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(421, 364);
            this.listaAlumnos.TabIndex = 5;
            // 
            // btnPasoDeAño
            // 
            this.btnPasoDeAño.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasoDeAño.Location = new System.Drawing.Point(846, 220);
            this.btnPasoDeAño.Name = "btnPasoDeAño";
            this.btnPasoDeAño.Size = new System.Drawing.Size(180, 50);
            this.btnPasoDeAño.TabIndex = 0;
            this.btnPasoDeAño.Text = "Paso de año";
            this.btnPasoDeAño.UseVisualStyleBackColor = true;
            this.btnPasoDeAño.Click += new System.EventHandler(this.btnPasoDeAño_Click);
            // 
            // btnCambioOrientacion
            // 
            this.btnCambioOrientacion.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioOrientacion.Location = new System.Drawing.Point(846, 286);
            this.btnCambioOrientacion.Name = "btnCambioOrientacion";
            this.btnCambioOrientacion.Size = new System.Drawing.Size(180, 56);
            this.btnCambioOrientacion.TabIndex = 6;
            this.btnCambioOrientacion.Text = "Cambio orientación";
            this.btnCambioOrientacion.UseVisualStyleBackColor = true;
            this.btnCambioOrientacion.Click += new System.EventHandler(this.btnCambioOrientacion_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(846, 359);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(180, 56);
            this.btnEliminarAlumno.TabIndex = 7;
            this.btnEliminarAlumno.Text = "Eliminar alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(846, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaAlumnos);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 392);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Alumnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1038, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnCambioOrientacion);
            this.Controls.Add(this.btnPasoDeAño);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Alumnos ORT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresarAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrientacion;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox listaAlumnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPasoDeAño;
        private System.Windows.Forms.Button btnCambioOrientacion;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

