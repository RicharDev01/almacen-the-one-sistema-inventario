using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  class Categoria
  {
    int idCategoria;
    string nombreCategoria;

    public Categoria()
    {

    }
    // metodos getter and setter
    public int IdCategoria { get => idCategoria; set => idCategoria = value; }
    public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }

  }// fin de clase Categoria
}// fin de namespace
