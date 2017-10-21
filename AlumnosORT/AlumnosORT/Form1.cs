using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlumnosORT
{
    public partial class Form1 : Form
    {
        List<Alumno> listaAlumnosORT = new List<Alumno>();
        Alumno alumnoSeleccionado;
        string [] orientaciones = new string [9];
        bool boolOrientacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarAlumno_Click(object sender, EventArgs e)
        {
            string error = "";

            string nombreAlumno = txtNombre.Text.Trim();
            string apellidoAlumno = txtApellido.Text.Trim();
            int añoAlumno = Convert.ToInt32(nudAño.Value);
            string orientacionAlumno = cmbOrientacion.Text;

            if (nombreAlumno == "")
            {
                error += "Nombre inválido.\n";
            }

            if (apellidoAlumno == "")
            {
                error += "Apellido inválido.\n";
            }

            if(añoAlumno>6 || añoAlumno<1)
            {
                error += "Año inválido.\n";
            }

            boolOrientacion = false;
            for (int i = 0; i < orientaciones.Length; i++)
            {
                if (orientaciones[i] == orientacionAlumno)
                {
                    boolOrientacion = true;
                }
            }

            if (añoAlumno > 0 && añoAlumno < 4 && orientacionAlumno != "Ciclo Básico")
            {
                if (boolOrientacion == false)
                {
                    error += "Orientación inválida.\n";
                }
                else
                {
                    error += "Año inválido / Orientación inválida.\n";
                }
            }

            if(añoAlumno > 3 && añoAlumno < 7 && boolOrientacion == false)
            {
                if(orientacionAlumno=="Ciclo Básico")
                {
                    error += "Año inválido / Orientación inválida.\n";
                }
                else
                {
                    error += "Orientación inválida.\n";
                }
            }


            if (error == "")
            {
                Alumno oAlumno = new Alumno(nombreAlumno, apellidoAlumno, añoAlumno, orientacionAlumno);
                bool funciono = Alumnos.GuardarAlumnos(oAlumno);

                if (funciono)
                {
                    listaAlumnosORT.Add(oAlumno);
                    ActualizarLista();

                    MessageBox.Show("Alumnno cargado correctamente", "PROCEDIMIENTO EXITOSO");

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    nudAño.Text = "";
                    cmbOrientacion.Text = "";
                }
                else
                {
                    MessageBox.Show("Hubo un error inesperado, por favor vuelva a intentar dentro de un rato.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show(error, "ERROR");
                error = "";
            }
        }

        private void ActualizarLista()
        {
            listaAlumnos.DataSource = null;
            listaAlumnos.DataSource = listaAlumnosORT;
        }

        private void btnPasoDeAño_Click(object sender, EventArgs e)
        {
            alumnoSeleccionado = (Alumno)listaAlumnos.SelectedItem;
            Alumno alumnoModificado = new Alumno(alumnoSeleccionado.GetNombre(), alumnoSeleccionado.GetApellido(), alumnoSeleccionado.GetAño(), alumnoSeleccionado.GetOrientacion());


            int añoDelAlumno = alumnoSeleccionado.GetAño();

            if (añoDelAlumno < 6)
            {
                if (añoDelAlumno == 3)
                {
                    alumnoModificado.PasoAño();

                    bool funciono = Alumnos.ModificarAlumno(alumnoSeleccionado, alumnoModificado);

                    if (funciono)
                    {
                        MessageBox.Show("Actualice especialidad del alumno", "PROMOVIDO AL CICLO SUPERIOR");
                        alumnoSeleccionado.PasoAño();
                        ActualizarLista();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error inesperado, por favor vuelva a intentar dentro de un rato.", "ERROR");
                    }
                }
                else
                {
                    if (añoDelAlumno == 4 && alumnoSeleccionado.GetOrientacion() == "Ciclo Básico")
                    {
                        MessageBox.Show("Cambie 'Ciclo Básico' por la orientación en la que se encuentra el alumno", "ERROR");
                    }
                    else
                    {
                        alumnoModificado.PasoAño();

                        bool funciono = Alumnos.ModificarAlumno(alumnoSeleccionado, alumnoModificado);
                        

                        if (funciono)
                        {
                            alumnoSeleccionado.PasoAño();
                            ActualizarLista();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error inesperado, por favor vuelva a intentar dentro de un rato.", "ERROR");
                        }
                    }
                }
            }
            else
            {
                bool funciono = Alumnos.EliminarAlumno(alumnoSeleccionado);

                if (funciono)
                {
                    listaAlumnosORT.Remove(alumnoSeleccionado);
                    ActualizarLista();
                    MessageBox.Show("Alumno graduado", "CICLO FINALIZADO");
                }
                else
                {
                    MessageBox.Show("Hubo un error inesperado, por favor vuelva a intentar dentro de un rato.", "ERROR");
                }
            }
        }

        private void btnCambioOrientacion_Click(object sender, EventArgs e)
        {
            alumnoSeleccionado = (Alumno)listaAlumnos.SelectedItem;

            string orientacionParaCambio = cmbOrientacion.Text;
            int añoAlumno = alumnoSeleccionado.GetAño();

            Alumno alumnoModificado = new Alumno(alumnoSeleccionado.GetNombre(), alumnoSeleccionado.GetApellido(), alumnoSeleccionado.GetAño(), alumnoSeleccionado.GetOrientacion());
            alumnoModificado.CambioDeOrientacion(orientacionParaCambio);


            if (añoAlumno > 3 && añoAlumno < 6)
            {
                boolOrientacion = false;
                for (int i = 0; i < orientaciones.Length; i++)
                {
                    if (orientaciones[i] == orientacionParaCambio)
                    {
                        boolOrientacion = true;
                    }
                }

                if (boolOrientacion == false)
                {
                    MessageBox.Show("Orientación inválida", "SOLICITUD DE CAMBIO DE ORIENTACIÓN INVÁLIDA");
                }
                else
                {
                    bool funciono = Alumnos.ModificarAlumno(alumnoSeleccionado, alumnoModificado);

                    if (funciono)
                    {
                        alumnoSeleccionado.CambioDeOrientacion(orientacionParaCambio);
                        ActualizarLista();
                        MessageBox.Show("Cambio de orientación realizado", "SOLICITUD EXITOSA");
                        cmbOrientacion.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error inesperado, por favor vuelva a intentar dentro de un rato.", "ERROR");
                    }
                }
            }
            else
            {
                if (añoAlumno < 4)
                {
                    MessageBox.Show("El alumno sigue en el ciclo básico", "SOLICITUD RECHAZADA");
                    cmbOrientacion.Text = "";
                }
                else
                {
                    MessageBox.Show("El alumno se encuentra en 6to año y por lo tanto no es posible el cambio de especialidad", "SOLICITUD RECHAZADA");
                    cmbOrientacion.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudAño.Text = "";

            orientaciones[0] = "Construcciones";
            orientaciones[1] = "Diseño Industrial";
            orientaciones[2] = "Electrónica";
            orientaciones[3] = "Gestión Administrativa";
            orientaciones[4] = "Informática y Medios de Comunicación Digitales";
            orientaciones[5] = "Producción de Medios de Comunicación";
            orientaciones[6] = "Producción Musical";
            orientaciones[7] = "Química";
            orientaciones[8] = "Tecnología de Información y Comunicación";

            listaAlumnosORT = Alumnos.ObtenerAlumnos();
            ActualizarLista();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            alumnoSeleccionado = (Alumno)listaAlumnos.SelectedItem;
            bool eliminado = Alumnos.EliminarAlumno(alumnoSeleccionado);

            if (eliminado)
            {
                listaAlumnosORT.Remove(alumnoSeleccionado);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Hubo un error inesperado, por favor vuelva a intentar dentro de un rato.","ERROR");
            }
        }

    }
}