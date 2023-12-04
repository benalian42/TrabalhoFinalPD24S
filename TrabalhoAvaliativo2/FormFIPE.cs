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

        private void FormFIPE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'trabalhoSegurosDataSet1.TabelaFIPE'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaFIPETableAdapter.Fill(this.trabalhoSegurosDataSet1.TabelaFIPE);
            // TODO: esta linha de código carrega dados na tabela 'trabalhoSegurosDataSet1.Apolices'. Você pode movê-la ou removê-la conforme necessário.
            this.apolicesTableAdapter.Fill(this.trabalhoSegurosDataSet1.Apolices);

        }

        private void tabelaFIPEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
