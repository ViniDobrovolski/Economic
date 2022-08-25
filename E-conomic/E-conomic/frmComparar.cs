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
    public partial class frmComparar : Form
    {
      public int idtipo = 0;
      public int idusuario = 0;
      public int finalid = 0;
        public frmComparar(int usuario, int finalidade)
        {
            idusuario = usuario;
            InitializeComponent();
            CarregarComboTipo();
            if (finalidade == 0)
            {
                CarregarComboDatas();
                finalid = finalidade;
            }
                
            if (finalidade == 1)
            {
                CarregarComboAno();
                finalid = finalidade;
            }
         
        }

        

        private void CarregarComboAno()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(2018, "2018");
            myDictionary.Add(2019, "2019");
            myDictionary.Add(2020, "2020");
            myDictionary.Add(2021, "2021");
            myDictionary.Add(2022, "2022");

            comboBox1.DataSource = myDictionary.ToArray();
            comboBox2.DataSource = myDictionary.ToArray();

            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";


        }

        public void CarregarComboTipo()
        {
            Model get = new Model();
            List<dtoTipo> lista = get.ListTipoGastos();
            cbSelecaoTipo.DataSource = lista;
            cbSelecaoTipo.DisplayMember = "nomegasto";
            cbSelecaoTipo.ValueMember = "id";
        }

        public void CarregarComboDatas()
        {
            comboBox1.Items.Insert(0, "");
            comboBox1.Items.Insert(1, "Janeiro");
            comboBox1.Items.Insert(2, "Fevereiro");
            comboBox1.Items.Insert(3, "Março");
            comboBox1.Items.Insert(4, "Abril");
            comboBox1.Items.Insert(5, "Maio");
            comboBox1.Items.Insert(6, "Junho");
            comboBox1.Items.Insert(7, "Julho");
            comboBox1.Items.Insert(8, "Agosto");
            comboBox1.Items.Insert(9, "Setembro");
            comboBox1.Items.Insert(10, "Outubro");
            comboBox1.Items.Insert(11, "Novembro");
            comboBox1.Items.Insert(12, "Dezembro");

            comboBox2.Items.Insert(0, "");
            comboBox2.Items.Insert(1, "Janeiro");
            comboBox2.Items.Insert(2, "Fevereiro");
            comboBox2.Items.Insert(3, "Março");
            comboBox2.Items.Insert(4, "Abril");
            comboBox2.Items.Insert(5, "Maio");
            comboBox2.Items.Insert(6, "Junho");
            comboBox2.Items.Insert(7, "Julho");
            comboBox2.Items.Insert(8, "Agosto");
            comboBox2.Items.Insert(9, "Setembro");
            comboBox2.Items.Insert(10, "Outubro");
            comboBox2.Items.Insert(11, "Novembro");
            comboBox2.Items.Insert(12, "Dezembro");

        }

   

        private void cbSelecaoTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idtipo = Convert.ToInt32(cbSelecaoTipo.SelectedValue);


        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (finalid == 0)
            {
                Model m = new Model();
                List<dtoGastoComparar> list1 = new List<dtoGastoComparar>();
                List<dtoGastoComparar> list2 = new List<dtoGastoComparar>();

                list1 = m.comparartipoGastosMes(idusuario, idtipo, comboBox1.SelectedIndex);
                list2 = m.comparartipoGastosMes(idusuario, idtipo, comboBox2.SelectedIndex);

                dataGrid1.DataSource = list1;
                dataGrid2.DataSource = list2;
            }

            else
            {
                Model m = new Model();
                List<dtoGastoComparar> list1 = new List<dtoGastoComparar>();
                List<dtoGastoComparar> list2 = new List<dtoGastoComparar>();

                list1 = m.comparartipoGastosAno(idusuario, idtipo, Convert.ToInt32(comboBox1.SelectedValue));
                list2 = m.comparartipoGastosAno(idusuario, idtipo, Convert.ToInt32(comboBox1.SelectedValue));

                dataGrid1.DataSource = list1;
                
                dataGrid2.DataSource = list2;
            }


        }

        private void dataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = ((int)dataGrid1.CurrentRow.Cells[0].Value).ToString();
                frmAdicionarGastos f = new frmAdicionarGastos(id);
                f.Show();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Esse gasto já foi excluído");
            }

            
        }
    }
}
