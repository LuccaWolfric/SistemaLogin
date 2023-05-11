using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false; // propriedade botão cancelar
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (CadastroUsuarios.Login(nome, senha)) // devolve "true" se os parametros estiverem corretos
            {
                Close();
            }
            else
            {
                MessageBox.Show("ACESSO NEGADO!");
                txtUsuario.Text = "";
                txtSenha.Text = ""; // esvazia os campos
                txtUsuario.Focus(); // foca no login novamente
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnSenha_Click(sender, e);
            }
        }
    }
}
