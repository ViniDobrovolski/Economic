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
    public partial class frmTipoGasto : Form
    {
        
        public frmTipoGasto()
        {
            InitializeComponent();
        }

        public frmTipoGasto(int id)
        {
            InitializeComponent();
            textBoxID.Text = id.ToString();
        }

        private void btn_SalvarTipo_Click(object sender, EventArgs e)
        {
            
                Model set = new Model();
                tipoGastos p = new tipoGastos();
                p.nomegasto = textBoxNome.Text;

                if (textBoxID.Text != string.Empty)
                {
                    p.id = int.Parse(textBoxID.Text);
                    set.EditTipoGasto(p);
                }
                else
                {
                    set.SetTipoGasto(p);
                }

            this.Close();

            frmAcoesTipo ac = new frmAcoesTipo();
            ac.Show();
           
            
        }

        private void frmTipoGasto_Load(object sender, EventArgs e)
        {

        }
    }
}
