using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEntrada entrada = new lvEntrada();
            entrada.ShowDialog();
        }

        private void saídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvSaida saida = new lvSaida();
            saida.ShowDialog();
        }
    }
}

