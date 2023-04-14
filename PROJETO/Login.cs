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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;//para que não mostre o formulário desconfigurado
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 230, this.Height / 2 - 230);//posiciona o FrmLogin no meio com os devios ajustes
            pnlLogin.Visible = true;//permite a visualização do FrmLogin

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) //validação de entrada de dado com o ENTER
            {
                ChamarLogin();
            }
        }
        private void ChamarLogin() 
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Preencha o usuário");
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a senha");
                txtSenha.Focus();
                return;
            }
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                FrmMenu form = new FrmMenu();
                this.Hide(); //usado para fechar o FrmLogin quando a tela princípal abrir
                form.Show();
                Limpar();
                txtUsuario.Focus();
            }
            else 
            {
                MessageBox.Show("Usuário ou senha inválidos");
                Limpar();
                txtUsuario.Focus();
                return;
            }
            
        }
        private void Limpar()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 230, this.Height / 2 - 230);
        }
    }
}
