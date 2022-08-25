using E_conomic.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_conomic
{
    public partial class frmAcoesTipo : Form
    {
        public frmAcoesTipo()
        {
            InitializeComponent();
            CarregarCombo();
        }

        public void CarregarCombo()
        {
            Model get = new Model();
            List<dtoTipo> lista = get.ListTipoGastos();
            comboTipo.DataSource = lista;
            comboTipo.DisplayMember = "nomegasto";
            comboTipo.ValueMember = "id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmTipoGasto f = new frmTipoGasto(Convert.ToInt32(comboTipo.SelectedValue));
            f.Show();
            this.Close();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Model m = new Model();
            m.DeletarTipoGasto(Convert.ToInt32(comboTipo.SelectedValue));

            MessageBox.Show("O tipo de gasto foi excluído");

            CarregarCombo();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmTipoGasto f = new frmTipoGasto();
            f.Show();
            this.Close();
        }
    }
}
