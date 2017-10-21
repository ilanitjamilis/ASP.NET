using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPersonas = Personas.ObtenerPersonas();
            this.ActualizarLista();
        }

        List<Persona> listaPersonas = new List<Persona>();

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            int edad = Convert.ToInt32(numericUpDown1.Value);
            string sexo;
            if (radioButton1.Checked)
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }

            Persona persona = new Persona(nombre, apellido, edad, sexo);

            bool funciono = Personas.GuardarPersona(persona);

            if (funciono)
            {
                listaPersonas.Add(persona);
                this.ActualizarLista();
                MessageBox.Show("Operación exitosa");
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            
          
        }

        private Persona personaSeleccionada;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            personaSeleccionada = (Persona)listBox1.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona personaModificada = new Persona(personaSeleccionada.GetNombre(), personaSeleccionada.GetApellido(), personaSeleccionada.GetEdad(), personaSeleccionada.GetSexo());
            personaModificada.CrecioUnAño();
            bool funciono = Personas.ModificarPersona(personaSeleccionada, personaModificada);
            if (funciono)
            {
                personaSeleccionada.CrecioUnAño();
                this.ActualizarLista();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void ActualizarLista()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = this.listaPersonas;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Persona personaModificada = new Persona(personaSeleccionada.GetNombre(), personaSeleccionada.GetApellido(), personaSeleccionada.GetEdad(), personaSeleccionada.GetSexo());
            personaModificada.CambioSexo();
  
            bool funciono = Personas.ModificarPersona(personaSeleccionada, personaModificada);
            if (funciono)
            {
                personaSeleccionada.CambioSexo();
                this.ActualizarLista();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool funciono = Personas.EliminarPersona(personaSeleccionada);
            if (funciono)
            {
                MessageBox.Show("Operación exitosa");
                listaPersonas.Remove(personaSeleccionada);
                listBox1.DataSource = null;
                listBox1.DataSource = listaPersonas;
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
