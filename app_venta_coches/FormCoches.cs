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

        }
    }
}
