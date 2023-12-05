using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAvaliativo2
{
    public partial class Wizard : Form
    {
        Timer timer = new Timer();        
        private void tornarFullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void telaAdministracao(  object sender, KeyEventArgs e )
        {
            if (e.Control && e.KeyCode == Keys.F5)
            {
                FormAdministrativo admin = new FormAdministrativo();
                admin.Show();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public Wizard()
        {
            InitializeComponent();

            //seta o intervalo do timer em 3 min
            timer.Interval = 180000;
            timer.Tick += reiniciarProcesso;

            tornarFullscreen();
            this.KeyDown += telaAdministracao;
        }

        private void reiniciarProcesso(object sender, EventArgs e)
        {
            Console.WriteLine("3 min passaram");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
