using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PROJETO
{
    internal partial class lvEntrada : Form
    {
        public lvEntrada()
        {
            InitializeComponent();
        }   

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
        private void UpdateListView()
        {
            lvtEntrada.Items.Clear();
            EntradaDAO entradaDAO = new EntradaDAO();

            List<EntradaFin> entradas = entradaDAO.ListarEntradas();
            if (entradas.Count > 0)
            {
                foreach (var colab in entradas)
                {
                    ListViewItem lv = new ListViewItem(colab.Id.ToString());
                    lv.SubItems.Add(colab.Valor);
                    lv.SubItems.Add(colab.Data);
                    lv.SubItems.Add(colab.Descricao);
                    lv.SubItems.Add(colab.Tipo);
                    lvtEntrada.Items.Add(lv);
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ClearFields()
        {
            txbValorEntrada.Clear();
            txbDataEntrada.Clear();
            txbDescricaoEntrada.Clear();
            txbTipoEntrada.Clear();
            txbValorEntrada.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
