using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class Pedidos
  {

    int idPedido;
    Proveedor proveedorId;
    Producto productoId;
    Usuario usuarioId;
    int cantidadPedido;
    DateTime fechaPedido;

    // metodos getter and setter
    public int IdPedido { get => idPedido; set => idPedido = value; }
    public Usuario UsuarioId { get => usuarioId; set => usuarioId = value; }
    public int CantidadPedido { get => cantidadPedido; set => cantidadPedido = value; }
    public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
    internal Proveedor ProveedorId { get => proveedorId; set => proveedorId = value; }
    internal Producto ProductoId { get => productoId; set => productoId = value; }

  }// fin de clase pedidos
} // fin de namaspace
