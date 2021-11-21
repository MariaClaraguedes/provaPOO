using _3C1MARIA29.Code.BLL;
using _3C1MARIA29.Code.DTO;
using _3C1MARIA29.Ui;
using System;
using System.Windows.Forms;

namespace _3C1MARIA29
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                FrmPlay Frmpost = new FrmPlay();
                Frmpost.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
