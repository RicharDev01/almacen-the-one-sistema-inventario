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

    public bool AddCategory(string categoria)
    {

      var exito = cdao.AddCategory(categoria);

      return exito;
    }// fin de metodo add

    public DataTable SearchCategory(string buscado)
    {

      DataTable table = new DataTable();

      var da = cdao.SearchCategory(buscado);

      da.Fill(table);

      return table;
    }

  }// fin de clase
}// fin de namespace
