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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            while (CadastroUsuarios.UsuarioLogado == null) // null é padrão de usuario logado
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.Cancelar == true) //significa que o usuario quer sair
                {
                    Application.Exit();
                    return;
                }

                label_BoasVindas.Text = "Bem vindo(a) \n" + CadastroUsuarios.UsuarioLogado.Nome;
                Visible = true;
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (CadastroUsuarios.UsuarioLogado.Nome == "Davi")
            {
                labelHint.Text = "A proxima dica está onde se pode ouvir \n o barulho das aguas - Davi";
            }

            if (CadastroUsuarios.UsuarioLogado.Nome == "Jaco")
            {
                labelHint.Text = "A proxima dica está onde se pode ouvir \n o barulho das aguas - Jaco";
            }

            if (CadastroUsuarios.UsuarioLogado.Nome == "Jesus")
            {
                labelHint.Text = "A proxima dica está onde se pode ouvir \n o barulho das aguas - Jesus";
            }


        }
    }
}
