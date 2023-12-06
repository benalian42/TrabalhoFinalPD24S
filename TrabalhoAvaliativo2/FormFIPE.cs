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
    public partial class FormFIPE : Form
    {
        public FormFIPE()
        {
            InitializeComponent();
        }

        private void tabelaFIPEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaFIPEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trabalhoSegurosDataSet);

        }

        private void FormFIPE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'trabalhoSegurosDataSet.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaFIPETableAdapter.Fill(this.trabalhoSegurosDataSet.TabelaFIPE);

        }
    }
}
