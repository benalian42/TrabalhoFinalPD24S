using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAvaliativo2
{
    public partial class FormModelos : Form
    {
        public FormModelos()
        {
            InitializeComponent();
        }

        private void modelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trabalhoSegurosDataSet);

        }

        private void FormModelos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'trabalhoSegurosDataSet.Modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.trabalhoSegurosDataSet.Modelos);

        }
    }
}
