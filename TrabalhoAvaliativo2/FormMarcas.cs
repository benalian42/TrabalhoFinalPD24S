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
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void marcasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trabalhoSegurosDataSet);

        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'trabalhoSegurosDataSet.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.trabalhoSegurosDataSet.Marcas);

        }
    }
}
