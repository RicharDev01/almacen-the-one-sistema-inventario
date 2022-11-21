using DAO;
using Entities;
using System;
using System.Collections.Generic;

namespace Controlador
{
  public class MainScreenController
  {
    MainScreenDAO ms = new MainScreenDAO();
    public List<string> getProductoMasVendido()
    {

      return ms.ProductoMasVendido();
    }
    public List<string> getProductoMenosVendido()
    {

      return ms.ProductoMenosVendido();
    }

  }// fin de clase
}
