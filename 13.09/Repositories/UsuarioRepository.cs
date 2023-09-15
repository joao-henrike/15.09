using _13._09.Contexts;
using Microsoft.Identity.Client;

namespace _13._09.Repositories
{
    public class UsuarioRepository
    {
        public class IUsuarioRepository : IUsuarioRepository
        {
            private readonly InlockContext ctx;

            public UsuarioRepository()
            {
                Public UsuarioRepository()
                {
                    CTX = new InlockContext();
                }

                Public Usuario BuscarUsuario(string email, string senha)
                {
                    throw new NotImplementedException();
                }

                Public void Cadastrar(Usuario usuario)
                {

                }

            }
        }
    }
}
