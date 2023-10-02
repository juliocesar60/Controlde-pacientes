using Administrador.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Administrador.Models;

namespace Administrador.Data
{
    public class Da_Logica
    {
        public List<Usuario> ListaUsuario()
        {
            return new List<Usuario>
            {
                new Usuario{ Nombre ="billy",Correo ="administrador@gmail.com",Clave ="123" ,Roles = new string[]{"Administrador" } },
                new Usuario{ Nombre ="julio",Correo ="supervisor@gmail.com",Clave ="123" ,Roles = new string[]{"Supervisor" } },
                new Usuario{ Nombre ="nichar",Correo ="paciente@gmail.com",Clave ="123" ,Roles = new string[]{"Paciente" } },
                new Usuario{ Nombre ="juan",Correo ="superpaciente@gmail.com",Clave ="123" ,Roles = new string[]{"Supervisor","Paciente" } }
            };
        }


        public Usuario ValidarUsuario(string _correo, string _clave){
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();

        }


    }
}
