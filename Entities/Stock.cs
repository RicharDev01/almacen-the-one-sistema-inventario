using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class Stock
  {

    int idStock;
    int cantidad;

    public Stock() { }

    // metodos getter and setter
    public int IdStock { get => idStock; set => idStock = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }

  } // fin de clase stock
}// fin de namespace
