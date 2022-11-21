using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class Venta
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

    public int IdVenta { get => idVenta; set => idVenta = value; }
    public Cliente ClienteId { get => clienteId; set => clienteId = value; }
    public Producto ProductoId { get => productoId; set => productoId = value; }
    public float CantidadCompra { get => cantidadCompra; set => cantidadCompra = value; }
    public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
    public string FormaPago { get => formaPago; set => formaPago = value; }
    public float Descuento { get => descuento; set => descuento = value; }
    public float MontoTotal { get => montoTotal; set => montoTotal = value; }
    public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }

    // metodos getter and setter


  }// fin de clase venta
}// fin de namespace
