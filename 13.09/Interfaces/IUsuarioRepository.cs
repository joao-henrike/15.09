using _13._09.Domains;

namespace _13._09.Interfaces
{
    public class IUsuarioRepository
    {
        Usuario BuscarUsuario(String email, string senha);

        void Cadastrar(Usuario usuario);
    }
}
