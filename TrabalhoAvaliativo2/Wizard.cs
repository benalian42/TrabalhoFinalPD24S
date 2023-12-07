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

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;

            //seta o intervalo do timer em 3 min
            timer.Interval = 180000;
            timer.Tick += reiniciarProcesso;

            tornarFullscreen();
            this.KeyDown += telaAdministracao;
        }

        public void chamarPainel(Panel atual, Panel proximo)
        {
            atual.Visible = false;
            proximo.Visible = true;
        }

        public void sair()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = true;

        }

        public void salvar()
        {

        }

        private void reiniciarProcesso(object sender, EventArgs e)
        {
            Console.WriteLine("3 min passaram");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chamarPainel(panel3, panel2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chamarPainel(panel4, panel3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
       
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chamarPainel(panel6, panel7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chamarPainel(panel2,panel3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chamarPainel(panel3, panel4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chamarPainel(panel4, panel7);   
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void Wizard_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            chamarPainel(panel7, panel4);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            chamarPainel(panel7, panel6);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sair();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
