using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puertoMasAlegre
{
    public partial class paginaPrincipas : Form
    {
        public paginaPrincipas()
        {
            InitializeComponent();
        }

        private void paginaPrincipas_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registroProducto frm = new registroProducto();
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            reportes frm = new reportes();
            frm.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            inventario frm = new inventario();
            frm.Show();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            movimientoProducto frm = new movimientoProducto();
            frm.Show();
        }

        private void btnPromocion_Click(object sender, EventArgs e)
        {
            promociones frm = new promociones();
            frm.Show();
        }
    }
}
