using EFCore;
using System.Collections.Generic;

namespace TFG.Contrato
{
    public interface IRepositoryUsuarios
    {
        List<Usuario> GetAllUsers();
        Usuario GetUser(int id);
        void InsertUser(Usuario usuario);
        void DeleteUser(Usuario usuario);
        void Login(string usuario, string password);
        void GuardarDatos();
    }
}
