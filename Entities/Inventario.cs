using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class Inventario
  {

    int inventarioId;
    Producto productoId;
    int entradas; 
    int salidas;
    float ingresos;
    float egresos;

    // metodos getter and setter
    public int InventarioId { get => inventarioId; set => inventarioId = value; }
    internal Producto ProductoId { get => productoId; set => productoId = value; }
    public int Entradas { get => entradas; set => entradas = value; }
    public int Salidas { get => salidas; set => salidas = value; }
    public float Ingresos { get => ingresos; set => ingresos = value; }
    public float Egresos { get => egresos; set => egresos = value; }

  
  } // fin de clase inventario
}// fin de namespace
