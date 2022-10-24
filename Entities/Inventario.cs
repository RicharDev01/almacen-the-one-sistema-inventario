using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  class Inventario
  {

    int inventarioId;
    Producto productoId;
    Categoria categoriaId;
    Pedidos pedidoId;
    Venta ventaId;
    Stock stockId;

    // metodos getter and setter
    public int InventarioId { get => inventarioId; set => inventarioId = value; }
    internal Producto ProductoId { get => productoId; set => productoId = value; }
    internal Categoria CategoriaId { get => categoriaId; set => categoriaId = value; }
    internal Pedidos PedidoId { get => pedidoId; set => pedidoId = value; }
    internal Venta VentaId { get => ventaId; set => ventaId = value; }
    internal Stock StockId { get => stockId; set => stockId = value; }
  
  } // fin de clase inventario
}// fin de namespace
