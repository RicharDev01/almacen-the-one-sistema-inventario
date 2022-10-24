using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  class Cliente: Usuario
  {
    int idCliente;
    string telefono;

    public Cliente() { }

    // metodos getter and setter
    public int IdCliente { get => idCliente; set => idCliente = value; }
    public string Telefono { get => telefono; set => telefono = value; }
  
  }// fin de calse
} // fin de namespace
