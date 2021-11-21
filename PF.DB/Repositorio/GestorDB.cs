using PF.DB.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF.DB.Repositorio
{
    class GestorDB
    {
        //Crear Usuario
        public int CrearUsuario(Usuario objUsuario) 
        {
            int n = 0;
            using (PF_IS39Entities ContextoBD = new PF_IS39Entities()) 
            {
                ContextoBD.Usuarios.Add(objUsuario);
                n = ContextoBD.SaveChanges();
            }
            return n;
        }
        // Borrar Usuario
        public int BorrarUsuario(int Id) 
        {
            int n = 0;
            using (PF_IS39Entities ContextoBD = new PF_IS39Entities()) 
            {
                var aux = ContextoBD.Usuarios.Where(x => x.ID == Id).FirstOrDefault(); if (aux == null)
                {
                    //Programación cuando no se encuentra
                    n = 0;
                }
                else 
                {
                    ContextoBD.Entry<Usuario>(aux).State = System.Data.Entity.EntityState.Deleted;
                    n = ContextoBD.SaveChanges();
                }
            }
            return n;
        }

        // En listar Objetos Usuario
        public IEnumerable<Usuario> ListadoUsuario()
        {
            List<Usuario> listadoRetornar = new List<Usuario>();
            using (PF_IS39Entities ContextBD = new PF_IS39Entities()) 
            {
                listadoRetornar = ContextBD.Usuarios.ToList();
            }
            return listadoRetornar;
        }

    }
}
