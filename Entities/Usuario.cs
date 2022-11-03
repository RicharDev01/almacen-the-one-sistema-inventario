using System;

namespace Entities
{
  public class Usuario
  {
    int idUsuario;
    string nombreUsuario;
    string apellidoUsuario;
    string emailUsuario;
    string rolUsuario;

    // constructor
    public Usuario()
    {
    }

    // metodos getter and setter
    public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
    public string RolUsuario { get => rolUsuario; set => rolUsuario = value; }
    public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
  } // fin de clase Usuario
}// fin de namespace
