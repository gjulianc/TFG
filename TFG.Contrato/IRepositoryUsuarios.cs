using EFCore;
using EFData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
