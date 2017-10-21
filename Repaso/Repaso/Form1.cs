/*
    1) Ingresar un valor en un textbox y me diga si es numérico o no. (Usar TryParse. Si no pueden, el lunes lo explico)
    2) Ingresar 10 numero por teclado. Crear una funcion que los ordene de forma ascendente y muestre. VALIDAR
    3) Ingresar 10 textos por teclado. Mostrar que texto ingresado es el más largo (con funcion).
    4) Ingresar la nota de 3 trimestres (por combo box o number picker cada una) y decir si el alumno aprobó o no. (con funcion).
    (Aprobó si tiene Promedio y el último trimestre mayor a 6)
    5) Crear un ejercicio que utilice sabiamente el Switch. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Form1 : Form
    {


        string[] palabras = new string[10]; 




        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerNumerico_Click(object sender, EventArgs e)
        {
            string numero;

            if (txtVerNumerico.Text != "")
            {
                numero = txtVerNumerico.Text;
                bool esNumerico = Funciones.esNumerico(numero);

                if (esNumerico)
                {
                    MessageBox.Show("El valor ingresado es numérico");
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es numérico");
                }
            }
            else
            {
                MessageBox.Show("Casilla vacía", "ERROR");
            }

        }

        private void txtVerNumerico_TextChanged(object sender, EventArgs e)
        {

        }

        string[] vecText = new string [10];
        int textosIngresados = 0;
        private void btnTextoLargo_Click(object sender, EventArgs e)
        {
            string textoIngresado = txtTextoLargo.Text.Trim();
            if (textoIngresado.Length>0)
            {
                vecText[textosIngresados] = textoIngresado;
                textosIngresados++;
                if (textosIngresados < 10)
                {
                    MessageBox.Show("Textos ingresados hasta el momento: " + textosIngresados + ".");
                }
                else
                {
                    int postextoLargo = -1;
                    int longTextoLargo = 0;

                    for (int i = 0; i <= 9; i++)
                    {
                        if (vecText[i].Length > longTextoLargo)
                        {
                            postextoLargo=i;
                            longTextoLargo = vecText[i].Length;
                        }
                    }

                    MessageBox.Show("El texto ingresado más largo es: " + vecText[postextoLargo] + ".");
                }

            }
            else
            {
                MessageBox.Show("Casilla vacía","ERROR");
            }

        }
  
        int[] vecNum = new int[10];
        int numerosIngresados = 0;
        string ordenamiento = "";

        private void btnAceptarOrdenar_Click(object sender, EventArgs e)
        {
            string numero;

            if (txtAceptarOrdenar.Text != "")
            {
                numero = txtAceptarOrdenar.Text;
                bool esNumerico = Funciones.esNumerico(numero);

                if (esNumerico)
                {
                    vecNum[numerosIngresados] = Convert.ToInt32(numero);
                    numerosIngresados++;
                    if (numerosIngresados < 10)
                    {
                        MessageBox.Show("Números ingresados hasta el momento: " + (numerosIngresados) + ".");
                    }
                    else
                    {
                        int auxNum;
                        for (int i = 0; i < vecNum.Length; i++)
                        {
                            for (int f = 0; f < vecNum.Length - 1; f++)
                            {
                                if (vecNum[f] > vecNum[f + 1])
                                {
                                    auxNum = vecNum[f + 1];
                                    vecNum[f + 1] = vecNum[f];
                                    vecNum[f] = auxNum;
                                }
                            }
                        }

                        for (int i = 0; i < vecNum.Length; i++)
                        {
                           ordenamiento+="\nNúmero: " + vecNum[i] + ", número de orden: " + (i+1)  +".";
                            vecNum[i] = 0; 
                        }
                        MessageBox.Show(ordenamiento,"ORDENAMIENTO DE VECTOR"); 

                    }

                }
                else
                {
                    MessageBox.Show("El valor ingresado no es numérico");
                }
            }
            else
            {
                MessageBox.Show("Casilla vacía", "ERROR");
            }


        }

        private void btnAprobo_Click(object sender, EventArgs e)
        {
            int nota1 = Convert.ToInt32(nudNota1.Value);
            int nota2 = Convert.ToInt32(nudNota2.Value);
            int nota3 = Convert.ToInt32(nudNota3.Value);

            bool aprobado = Funciones.aprobo(nota1, nota2, nota3);

            if (aprobado)
            {
                MessageBox.Show("El alumno está aprobado");
            }
            else
            {
                MessageBox.Show("El alumno no está aprobado");
            }
        }

       
    }
}
