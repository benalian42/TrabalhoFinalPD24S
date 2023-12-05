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
    public partial class FormAdministrativo : Form
    {
        FormFIPE formFipe;
        FormMarcas formMarcas;
        FormModelos formModelos;
        public FormAdministrativo()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formMarcas = new FormMarcas();
            formMarcas.MdiParent = this;
            formMarcas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabelaFIPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formFipe = new FormFIPE();
            formFipe.MdiParent = this;
            formFipe.Show();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formModelos = new FormModelos();
            formModelos.MdiParent = this;
            formModelos.Show();
        }
    }
}
