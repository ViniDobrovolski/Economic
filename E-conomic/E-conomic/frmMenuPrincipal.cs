using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_conomic.Class;
using LoginScreen;

namespace E_conomic
{
    public partial class frmMenuPrincipal : Form
    {
        public int idusuariologado;
        public frmMenuPrincipal(int usuariologado)
        {

            InitializeComponent();
            idusuariologado = usuariologado;
            CarregarCampos();

        }

        public void CarregarCampos()
        {
            Model get = new Model();
            List<dtoGastoComparar> list1 = new List<dtoGastoComparar>();
            List<dtoGastoComparar> list2 = new List<dtoGastoComparar>();
            List<dtoGastoComparar> list3 = new List<dtoGastoComparar>();
            List<dtoGastoComparar> list4 = new List<dtoGastoComparar>();


            list1 = get.comparartipoGastosMes(idusuariologado, 10, DateTime.Now.Month);
            list2 = get.comparartipoGastosMes(idusuariologado, 11, DateTime.Now.Month);
            list3 = get.comparartipoGastosMes(idusuariologado, 12, DateTime.Now.Month);
            list4 = get.comparartipoGastosMes(idusuariologado, 13, DateTime.Now.Month);

            dataSaude.DataSource = list1;
            dataEducacao.DataSource = list2;
            dataMercado.DataSource = list3;
            dataOutros.DataSource = list4;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdicionarGastos f = new frmAdicionarGastos(idusuariologado);
            f.Show();
        }

        

        private void btnAdicionarTipo_Click(object sender, EventArgs e)
        {
            frmAcoesTipo f = new frmAcoesTipo();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEscolhaComparar f = new frmEscolhaComparar(idusuariologado);
            f.Show();
        }

        private void btnResumo_Click(object sender, EventArgs e)
        {
            frmResumosGastos f = new frmResumosGastos(idusuariologado);
            f.Show();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            frmCadastro f = new frmCadastro(idusuariologado);
            f.Show();
            this.Close();
        }

        private void dataSaude_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = ((int)dataSaude.CurrentRow.Cells[0].Value).ToString();
                frmAdicionarGastos f = new frmAdicionarGastos(id);
                f.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Esse gasto já foi excluído");
            }
        }

        private void dataEducacao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = ((int)dataEducacao.CurrentRow.Cells[0].Value).ToString();
                frmAdicionarGastos f = new frmAdicionarGastos(id);
                f.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Esse gasto já foi excluído");
            }
        }

        private void dataMercado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = ((int)dataMercado.CurrentRow.Cells[0].Value).ToString();
                frmAdicionarGastos f = new frmAdicionarGastos(id);
                f.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Esse gasto já foi excluído");
            }
        }

        private void dataOutros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = ((int)dataOutros.CurrentRow.Cells[0].Value).ToString();
                frmAdicionarGastos f = new frmAdicionarGastos(id);
                f.Show();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Esse gasto já foi excluído");
            }
        }

       

        private void frmMenuPrincipal_MouseEnter(object sender, EventArgs e)
        {
            CarregarCampos();
        }
    }
}
