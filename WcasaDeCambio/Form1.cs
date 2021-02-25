using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Fecha: Febrero 23 de 2021
/// Autor: Alen Yair Camargo Zapata
/// Descripcion: Formulario de casa de cambio
/// </summary>
namespace WcasaDeCambio
{
    public partial class frmCasaDeCambio : Form
    {
        public frmCasaDeCambio()
        {
            InitializeComponent();
            InicializarFormulario();
            
            
        }

        private void InicializarFormulario()
        {
            try
            {
                // Inicializar cada texbox 
                txtNombre.Text = "";
                txtDireccion.Text="";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCantidadValorCambiar.Text = "";
                txtValordelcanje.Text = "";

                // regiones

                #region[llenar combo ciudad]
                cmbCiudad.Items.Clear();
                cmbCiudad.Items.Add("Medellin");
                cmbCiudad.Items.Add("Barcelona");
                cmbCiudad.Items.Add("Washinton");
                #endregion
                #region[Combo moneda origen]
                cmbMonedaOrigen.Items.Clear();
                cmbMonedaOrigen.Items.Add("Pesos");
                cmbMonedaOrigen.Items.Add("Euros");
                cmbMonedaOrigen.Items.Add("Dolar");
                #endregion

                #region[Llenar Combo moneda destino]
                cmbMonedaDestino.Items.Clear();
                cmbMonedaDestino.Items.Add("Pesos");
                cmbMonedaDestino.Items.Add("Euros");
                cmbMonedaDestino.Items.Add("Dolar");
                #endregion

                rdoEfectivo.Checked = true;
            }
            catch (Exception Err)
            {

                MessageBox.Show(Err.Message);
            }
        }

       

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            // Definicion e iniciacion de variables
            double Valor = 0;
            double CantidadValorCambiar = double.Parse(txtCantidadValorCambiar.Text);
            double ValorCanje = double.Parse(txtValordelcanje.Text);
           
            string usuario;
            usuario =  "Nombre " + txtNombre.Text + "\n" + "Apellido " +  txtApellido.Text +"\n" + "Direcion "+ txtDireccion.Text + "\n" +  "Telefono " +txtTelefono.Text + "\n" + "Ciudad " + cmbCiudad.Text;
            usuario = usuario + " El valor a pagar es: " ;
            // Proteccion en caso de que coloquen el mismo tipo de moneda
            if (cmbMonedaOrigen.Text == cmbMonedaDestino.Text)
            {
                MessageBox.Show(" Verifique que los tipos de monedas sean diferentes ");

            }

            else
            {
                // Calcular las conversiones de las monedas
                switch (cmbMonedaDestino.Text)
                {
                    case "Pesos":
                        Valor = CantidadValorCambiar * ValorCanje; usuario = usuario + Valor + " Pesos colombianos ";
                        break;

                    case "Euros":
                        Valor = CantidadValorCambiar / ValorCanje; usuario = usuario + Valor + " Euros ";
                        break;

                    case "Dolar":
                        Valor = CantidadValorCambiar / ValorCanje; usuario = usuario + Valor + " Dolares ";
                        break;

                    default:; break;

                }
                MessageBox.Show(usuario);
            }


           

        }
        // Confirmacion de salida
        private void frmCasaCambio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
