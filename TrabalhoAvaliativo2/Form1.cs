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
    public partial class Form1 : Form
    {
        
        private void tornarFullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void telaAdministracao(  object sender, KeyEventArgs e )
        {
            if (e.Control && e.KeyCode == Keys.F5)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                
            }
            
        }

        public Form1()
        {
            InitializeComponent();
            //teste
            
            tornarFullscreen();
            this.KeyDown += telaAdministracao;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
