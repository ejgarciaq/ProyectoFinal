using PF.DB.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF.DB.Interface
{
    interface IGestor
    {
        IEnumerable<Usuario> ListadoUsuarios();
        int CrearUsuario(Usuario objUsuario);
        int ActualizarUsuario(Usuario objUsuario);
        int BorrarUsuario(int Id);
    }
}
