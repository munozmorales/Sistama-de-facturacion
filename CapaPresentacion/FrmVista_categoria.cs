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
    public partial class FrmVista_categoria : Form
    {
        public FrmVista_categoria()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataCategoria.Columns[0].Visible = false;
            // this.dataCategoria.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.dataCategoria.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            lbTotal.Text = "Total Registros: " + Convert.ToString(dataCategoria.Rows.Count);
        }

        private void BuscarNombre()
        {
            this.dataCategoria.DataSource = NCategoria.BuscarNombre(this.txtBucar.Text);
            this.OcultarColumnas();
            lbTotal.Text = "Total Registros: " + Convert.ToString(dataCategoria.Rows.Count);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void chcEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmVista_categoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBucar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void dataCategoria_DoubleClick(object sender, EventArgs e)
        {
            Frmarticulo form = Frmarticulo.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataCategoria.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.dataCategoria.CurrentRow.Cells["nombre"].Value);
            form.setCategoria(par1, par2);
            this.Hide();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
