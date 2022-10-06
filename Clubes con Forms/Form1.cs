/*
Se tienen 17 clubes 
Socio codigo temporal, permanente -Codigo y edad del socio- 
Imprimir c/club que tiene mas socios si temporales o permanentes
Solo se cuentan los socios mayores a 18 años
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubes_con_Forms
{
    public partial class Form1 : Form
    {
        //declaro e incializo las variables que se usan en los dos botones
        int temporales = 0;
        int permanentes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //variables dentro del boton agregar
            int n; 
            string radioboton;
            int edadSocio;

            edadSocio = int.Parse(txtEdad.Text); //convierto de string a int

            //comprobacion de los radiobuttons
            if (rbPermanente.Checked) //si permamente esta tildado
            {
                radioboton = rbPermanente.Text; //agrego a una variable el texto del boton
                if (edadSocio >= 18) //y si ademas el socio permamente tiene +18
                {
                    permanentes++; //sumo uno a la variable permamente
                }
            }
            else 
            {
                radioboton = rbTemporal.Text; //si temporal esta tildado
                if (edadSocio >= 18) 
                {
                    temporales++;
                }
            }
            


            if (txtEdad.Text != "" || txtNombre.Text != "") //comprobacion de que los campos no esten vacios
            {
                lblError.Text = ""; //limpio el mensaje de error


                //Adicionamos nuevo renglon
                n = dtgvDatos.Rows.Add(); //aumenta una fila y regresa su indice

                //colocamos la informacion
                dtgvDatos.Rows[n].Cells[0].Value = lblNum.Text; //tomamos las filas de indice n
                                                                //en la columna 0


                dtgvDatos.Rows[n].Cells[1].Value = txtNombre.Text;//lo mismo con tasa
                                                                  //en la columna 1

                dtgvDatos.Rows[n].Cells[2].Value = txtEdad.Text;//lo mismo con dias
                                                                //en la columna 2

                dtgvDatos.Rows[n].Cells[3].Value = radioboton;//lo mismo con dias
                                                              //en la columna 2

                //vacio los textboxs
                txtNombre.Text = ""; 
                txtEdad.Text = "";
            }
            else //si alguno de los campos esta vacio
            {
                lblError.Text = "Error: Hay un campo vacio";  //mensaje de error
            }

        } //FIN BOTON AGREGAR


        //BOTON CAMBIAR CLUB
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //variables del boton cambiar club
            int numeroClub;
            string Club;

            numeroClub = int.Parse(lblNum.Text); //paso de string(por defecto) a int

            if(numeroClub < 17) //si el numero de club es menor a 17
            {
                //imprimo en una message box la cantidad de socios permanentes y temporales
                MessageBox.Show("El club Numero " + lblNum.Text + " posee " + permanentes + " socios permanentes y " + temporales + " socios temporales");
                numeroClub++; //sumo uno al numero del club
                Club = Convert.ToString(numeroClub); //Lo vuelvo a convertir a string
                lblNum.Text = Club; //y lo imprimo de nuevo en el lbl del formulario

                //vuelvo las variables de los permamentes y los temporales a 0 
                permanentes = 0;
                temporales = 0;
        
            }
            else
            {
                MessageBox.Show("Se terminaron los clubes"); //si ya se cargaron los 17 clubes un mensaje lo avisa

            }   

        } //FIN BOTON CAMBIAR CLUB

    }
}
