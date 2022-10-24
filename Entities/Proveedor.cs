using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  class Proveedor
  {
    int idProveedor;
    string nombreProveedor;
    string direccion;
    string telefono;

    public Proveedor() { }

    // metodos getter and setter
    public int IdProveedor { get => idProveedor; set => idProveedor = value; }
    public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
  
  }//  fin de clase Proveedor
}// fin de namaspace
