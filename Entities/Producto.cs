using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class Producto
  {

    int idProducto;
    Proveedor proveedorId;
    Categoria categoriaId;
    Stock stockId;
    string nombreProducto;
    float precioDeCompra;
    float precioDeVenta;
    DateTime fechaIngreso;

    public int IdProducto { get => idProducto; set => idProducto = value; }
    public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    public float PrecioDeCompra { get => precioDeCompra; set => precioDeCompra = value; }
    public float PrecioDeVenta { get => precioDeVenta; set => precioDeVenta = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    internal Proveedor ProveedorId { get => proveedorId; set => proveedorId = value; }
    internal Categoria CategoriaId { get => categoriaId; set => categoriaId = value; }
    internal Stock StockId { get => stockId; set => stockId = value; }

    // metodos getter and setter


  }// fin de clase

} // namespace
