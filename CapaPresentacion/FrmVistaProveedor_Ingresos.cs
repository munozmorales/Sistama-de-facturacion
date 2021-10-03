using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmVistaProveedor_Ingresos : Form
    {
        public FrmVistaProveedor_Ingresos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVistaProveedor_Ingresos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
        //Metodo ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //metodo mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = Nproveedor.Mostrar();
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        //Metoddos Razón social
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = Nproveedor.BuscarRazon_Social(txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = Nproveedor.BuscarNum_Documento(txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngresos form = FrmIngresos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idprovedor"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            form.setProveedor(par1, par2);
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.ShowDialog();
        }
    }
}
