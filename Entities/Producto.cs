using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  class Producto
  {

    int idProducto;
    Proveedor proveedorId;
    Categoria categoriaId;
    Stock stockId;
    string nombreProducto;
    float precioPorducto;

    // metodos getter and setter
    public int IdProducto { get => idProducto; set => idProducto = value; }
    public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    public float PrecioPorducto { get => precioPorducto; set => precioPorducto = value; }
    internal Proveedor ProveedorId { get => proveedorId; set => proveedorId = value; }
    internal Categoria CategoriaId { get => categoriaId; set => categoriaId = value; }
    internal Stock StockId { get => stockId; set => stockId = value; }

  }// fin de clase

} // namespace
