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
    public partial class frmAdicionarGastos : Form
    {
        public int usuariologado;
        public int idg;
        public frmAdicionarGastos(int idusuariologado)
        {
            InitializeComponent();
            usuariologado = idusuariologado;
            CarregarCombo();
            
        }

        public frmAdicionarGastos(string idgasto)
        {
            InitializeComponent();
            idg = Convert.ToInt32(idgasto);
            CarregarCombo();
            CarregarValores();

        }

        private void CarregarValores()
        {
            Model get = new Model();
            dtoGasto n = new dtoGasto();

            n = get.GetGasto(idg);

            textID.Text = n.id.ToString();
            textNome.Text = n.nome;
            textValor.Text = n.valor.ToString();
            textDescricao.Text = n.descricao;



        }

        public void CarregarCombo()
        {
            Model get = new Model();
            List<dtoTipo> lista = get.ListTipoGastos();
            comboTipoGasto.DataSource = lista;
            comboTipoGasto.DisplayMember = "nomegasto";
            comboTipoGasto.ValueMember = "id";
        }



        private void btn_SalvarGasto_Click(object sender, EventArgs e)
        {
           // try
           // {
                Model set = new Model();
                DbnovoGasto p = new DbnovoGasto();
                p.nome = textNome.Text;
                p.valor = decimal.Parse(textValor.Text);
                p.descricao = textDescricao.Text;
                p.tipoid = Convert.ToInt32(comboTipoGasto.SelectedValue);
                p.usuarioid = usuariologado;
                p.datagasto = DateTime.Now;
                if (textID.Text != string.Empty)
                {
                    p.id = int.Parse(textID.Text);
                    set.EditGasto(p);
                this.Close();
                frmComparar.ActiveForm.Focus();
                
            }
                else
                {
                    set.SetGasto(p);
                    this.Close();
                }
                
            }
            //catch (Exception ex)
           // {
              //  MessageBox.Show(ex.Message);
           // }
       // }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (textID.Text != string.Empty)
            {
                Model del = new Model();
                del.DeletarGasto(int.Parse(textID.Text));

                this.Close();
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
