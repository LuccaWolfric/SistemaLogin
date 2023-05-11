using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal static class CadastroUsuarios
    {
        private static Usuario[] usuarios { get; set; } =
        {
            new Usuario(){ Nome = "Davi", Senha = "absalao"}, //Prova 1
            new Usuario(){ Nome = "Jaco", Senha = "jose"}, // Prova 2
            new Usuario(){ Nome = "Jesus", Senha = "getsemani"} //Prova 3
        };

        private static Usuario _userLogado = null; //Usuario logado no momento

        public static Usuario UsuarioLogado //Propriedade que manipula o usuario logado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
