using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AFA_ListasDiccionarios
{
    public partial class Form1 : Form
    {

        int deuda;

        Dictionary<string, Dictionary<string, int>> divisiones = new Dictionary<string, Dictionary<string, int>>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Hacer función para verificar los errores

            string error = "";


            if (rbtCargar.Checked == false && rbtConsultar.Checked == false)
            {
                error += "Seleccione operación a realizar.\n";
            }

            string division = txtDivision.Text.Trim();
            bool isLetter = !String.IsNullOrEmpty(division) && Char.IsLetter(division[0]);
            if (isLetter == false)
            {
                error += "División inválida.\n";
            }

            string equipo = txtEquipo.Text.Trim();
            if (equipo == "")
            {
                error += "Equipo inválido.\n";
            }

            if (rbtCargar.Checked)
            {
                
                bool esNum = int.TryParse(txtDeuda.Text, out deuda);
                if (esNum == false || deuda <= 0)
                {
                    error += "Deuda inválida.\n";
                }
            }

            if (error == "")
            {
                bool divisionEncontrada = false;
                foreach (string letra in divisiones.Keys)
                {
                    if (division == letra)
                    {
                        divisionEncontrada = true;
                    }
                }


                if (rbtCargar.Checked)
                {
                    //Buscar si existe el equipo
                    //Si existe, sumar int a deuda, 
                    //sino, crear nuevo equipo.

                    
                    if (divisionEncontrada != true)
                    {
                        divisiones.Add(division, new Dictionary<string, int>());
                        Dictionary<string, int> dicEquipos = divisiones[division];
                        dicEquipos.Add(equipo, deuda);

                        MessageBox.Show("Equipo cargado correctamente","PROCEDIMIENTO EXITOSO");
                        txtDivision.Text = "";
                        txtEquipo.Text = "";
                        txtDeuda.Text = "";
                    }
                    else
                    {
                        bool equipoEncontrado = false;
                        Dictionary<string, int> dicEquipos = divisiones[division];
                        foreach (string item in dicEquipos.Keys)
                        {
                            if (item == equipo)
                            {
                                equipoEncontrado = true;
                                //Acumular deuda
                                dicEquipos[item] += deuda;
                                MessageBox.Show("Equipo actualizado correctamente", "PROCEDIMIENTO EXITOSO");
                            }
                        }
                        if (equipoEncontrado == false)
                        {
                            dicEquipos.Add(equipo, deuda);
                            MessageBox.Show("Equipo cargado correctamente", "PROCEDIMIENTO EXITOSO");
                        }
                    }
                }



                else //rbtConsultar.checked
                {
                    if (divisionEncontrada)
                    {
                        //Buscar si existe equipo
                        //If equipo existe mostrar deuda
                        //Else "equipo no existente"

                        bool equipoEncontrado = false;
                        Dictionary<string, int> dicEquipos = divisiones[division];
                        foreach (string item in dicEquipos.Keys)
                        {
                            if (item == equipo)
                            {
                                equipoEncontrado = true;
                                MessageBox.Show("Equipo: "+equipo+" - Deuda: "+dicEquipos[equipo]+".","DEUDA");
                                txtDivision.Text = "";
                                txtEquipo.Text = "";
                                txtDeuda.Text = "";
                            }
                        }
                        if (equipoEncontrado == false)
                        {
                            MessageBox.Show("El equipo que quiere consultar no existe!", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El equipo que quiere consultar no existe!","ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show(error,"ERROR");
                error = "";
            }



        }
    }
}
