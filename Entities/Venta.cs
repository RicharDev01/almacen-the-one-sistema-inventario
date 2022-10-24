using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  class Venta
  {

    int idVenta;
    Cliente clienteId;
    Producto productoId;
    float cantidadCompra;
    float precioUnitario;
    string formaPago;
    float descuento;
    float montoTotal;
    DateTime fechaVenta;

    public Venta() { }

    // metodos getter and setter
    public int IdVenta { get => idVenta; set => idVenta = value; }
    public float CantidadCompra { get => cantidadCompra; set => cantidadCompra = value; }
    public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
    public string FormaPago { get => formaPago; set => formaPago = value; }
    public float Descuento { get => descuento; set => descuento = value; }
    public float MontoTotal { get => montoTotal; set => montoTotal = value; }
    public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
    internal Cliente ClienteId { get => clienteId; set => clienteId = value; }
    internal Producto ProductoId { get => productoId; set => productoId = value; }

  }// fin de clase venta
}// fin de namespace
