using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AFA_Clases
{
    
    public partial class Form1 : Form
    {
        List<Division> listaDivisiones = new List<Division>();
        string error = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptarDivision_Click(object sender, EventArgs e)
        {
            string division = txtDivision.Text.Trim();
            bool divisionExiste = false;

            if (division != "")
            {
                foreach (Division divisionSeleccionada in listaDivisiones)
                {
                    if (divisionSeleccionada.nombre == division)
                    {
                        divisionExiste = true;
                    }
                }

                if (divisionExiste != true)
                {
                    Division oDivision = new Division(division);
                    oDivision.listaEquipos = new List<Equipo>();
                    listaDivisiones.Add(oDivision);

                    MessageBox.Show("División cargada correctamente", "PROCEDIMIENTO EXITOSO");

                    cmbDivisionParaEquipo.DataSource = null;
                    cmbDivisionParaEquipo.DataSource = listaDivisiones;
                    cmbDivisionParaEquipo.DisplayMember = "nombre";

                    cmbDivisionParaJugador.DataSource = null;
                    cmbDivisionParaJugador.DataSource = listaDivisiones;
                    cmbDivisionParaJugador.DisplayMember = "nombre";

                    cmbDivisionConsultar.DataSource = null;
                    cmbDivisionConsultar.DataSource = listaDivisiones;
                    cmbDivisionConsultar.DisplayMember = "nombre";
                }
                else
                {
                    MessageBox.Show("División ya existente","ERROR");
                }
            }
            else
            {
                MessageBox.Show("Division inválida","ERROR");
            }

        }

        
        private void btnAceptarEquipo_Click(object sender, EventArgs e)
        {
            Division divisionSeleccionada = (Division)cmbDivisionParaEquipo.SelectedItem;
            string nombreEquipo = txtEquipo.Text.Trim();

            if (listaDivisiones.Contains(divisionSeleccionada))
            {
                if (nombreEquipo != "")
                {
                    Equipo oEquipo = new Equipo(nombreEquipo);
                    oEquipo.listaJugadores = new List<Jugador>();

                    divisionSeleccionada.listaEquipos.Add(oEquipo);

                    MessageBox.Show("Equipo cargado correctamente","PROCEDIMIENTO EXITOSO");
                    txtEquipo.Text = "";
                }
                else
                {
                    MessageBox.Show("Equipo inválido", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("División inválida","ERROR");
            }
        }

        private void btnAceptarJugador_Click(object sender, EventArgs e)
        {
            Division divisionSeleccionada = (Division)cmbDivisionParaJugador.SelectedItem;
            Equipo equipoSeleccionado = (Equipo)cmbEquipoParaJugador.SelectedItem;

            string nombre = txtNombreJugador.Text.Trim();
            int numero = Convert.ToInt32(nudNumeroJugador.Value);
            string posicion = cmbPosicionJugador.Text;
            if (cmbEquipoParaJugador.Text != "")
            {
                if (nombre == "")
                {
                    error += "Nombre inválido";
                }
                if (numero <= 0)
                {
                    error += "/nNúmero inválido";
                }
                if (posicion == "")
                {
                    error += "/nPosición inválida";
                }
                if (error == "")
                {
                    if (listaDivisiones.Contains(divisionSeleccionada) && divisionSeleccionada.listaEquipos.Contains(equipoSeleccionado))
                    {
                        Jugador oJugador = new Jugador(nombre);
                        oJugador.numero = numero;
                        oJugador.posicion = posicion;

                        equipoSeleccionado.listaJugadores.Add(oJugador);

                        MessageBox.Show("Jugador cargado correctamente", "PROCEDIMIENTO EXITOSO");

                        txtNombreJugador.Text = "";
                        nudNumeroJugador.Text = "0";
                        cmbPosicionJugador.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(error, "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("División/Equipo inválido","ERROR");
            }
        }
        

        Equipo equipoSeleccionadoParaConsultar;
        private void cmbEquipoConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipoSeleccionadoParaConsultar = (Equipo)cmbEquipoConsultar.SelectedItem;
            if (equipoSeleccionadoParaConsultar.listaJugadores.Count > 0)
            {
                cmbNombreConsultar.DataSource = null;
                cmbNombreConsultar.DataSource = equipoSeleccionadoParaConsultar.listaJugadores;
            }
            else
            {
                cmbNombreConsultar.Text = "no hay jugadores";
            }
        }

        Jugador jugadorSeleccionadoParaConsultar;
        private void btnConsultarJugador_Click(object sender, EventArgs e)
        {
            jugadorSeleccionadoParaConsultar=(Jugador)cmbNombreConsultar.SelectedItem;

            if(listaDivisiones.Contains(divisionSeleccionadaParaConsultar))
            {
                if(divisionSeleccionadaParaConsultar.listaEquipos.Contains(equipoSeleccionadoParaConsultar))
                {
                    if (equipoSeleccionadoParaConsultar.listaJugadores.Contains(jugadorSeleccionadoParaConsultar))
                    {
                        MessageBox.Show("Nombre: " + jugadorSeleccionadoParaConsultar.nombre + ".\nNúmero: " + jugadorSeleccionadoParaConsultar.numero + ".\nPosición: " + jugadorSeleccionadoParaConsultar.posicion + ".","INFORMACIÓN JUGADOR");
                    }
                    else
                    {
                        MessageBox.Show("Jugador inexistente en el equipo: " + equipoSeleccionadoParaConsultar.nombre + " de la división: " + divisionSeleccionadaParaConsultar.nombre + ".", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Equipo inexistente en la división: " + divisionSeleccionadaParaConsultar.nombre + ".", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("División inexistente","ERROR");
            }

        }

        
        Division divisionSeleccionadaParaConsultar;
        private void cmbDivisionConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisionSeleccionadaParaConsultar = (Division)cmbDivisionConsultar.SelectedItem;
            if (divisionSeleccionadaParaConsultar.listaEquipos.Count > 0)
            {
                cmbEquipoConsultar.DataSource = null;
                cmbEquipoConsultar.DataSource = divisionSeleccionadaParaConsultar.listaEquipos;
                cmbEquipoConsultar.DisplayMember = "nombre";
            }
            else
            {
                cmbEquipoConsultar.Text = "no hay equipos";
            }
        }

        Division divisionSeleccionadaParaJugador;
        private void cmbDivisionParaJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisionSeleccionadaParaJugador = (Division)cmbDivisionParaJugador.SelectedItem;
            if (divisionSeleccionadaParaJugador.listaEquipos.Count > 0)
            {
                cmbEquipoParaJugador.DataSource = null;
                cmbEquipoParaJugador.DataSource = divisionSeleccionadaParaJugador.listaEquipos;
                cmbEquipoParaJugador.DisplayMember = "nombre";
            }
            else
            {
                cmbEquipoParaJugador.Text = "no hay equipos";
            }
        }

    }
}
