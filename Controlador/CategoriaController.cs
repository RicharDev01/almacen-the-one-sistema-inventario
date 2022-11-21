using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAO;

namespace Controlador
{
  public class CategoriaController
  {
    CategoriaDAO cdao = new CategoriaDAO();
    public DataTable getDataFillCategoria()
    {
      DataTable tabla = new DataTable();
      cdao.getCategorias().Fill(tabla);

      return tabla;
    }

  }// fin de clase
}// fin de namespace
