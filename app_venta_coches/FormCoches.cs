using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_venta_coches.ServiceRefCoches;

namespace app_venta_coches
{
    public partial class FormCoches : Form
    {
        //Instancia del servicio 
        ServiceCochesClient cliente = new ServiceCochesClient();
        //instacia de la clase coches
        Coches coche = new Coches();
        public FormCoches()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Deshabilita caja de texto
            txtMatricula.Enabled = false;
            //asignar a una variable string lo que trae la atricula
            string matricula = txtMatricula.Text;
            if (matricula.Trim() == "") //trim elimina los espacios
            {
                lblMensaje.Text = "Falta ingresar la matricula";
                return;
            }
            coche = cliente.buscarCoche(matricula);
            txtMarca.Text = coche.Marca;
            txtModelo.Text = coche.Modelo;
            txtColor.Text = coche.Color;
            txtPrecio.Text = coche.Precio.ToString();

            lblMensaje.Text = String.Format(
                "new vent anch = {0}",
                525 + btnAgregar.Location.X - btnSalir.Location.X
            );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Habilitar el textbox matricula
            txtMatricula.Enabled = true;
            //Limpiamos todas las cajas de texto
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
            
        }
    }
}
