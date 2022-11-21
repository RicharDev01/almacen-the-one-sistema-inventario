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
    public DataTable SearchCategory(string buscado)
    {

      DataTable table = new DataTable();

      var da = cdao.SearchCategory(buscado);

      da.Fill(table);

      return table;
    }

    public bool AddCategory(string categoria)
    {

      var exito = cdao.AddCategory(categoria);

      return exito;
    }// fin de metodo add

    public bool EditCategory(int id, string categoria)
    {

      var exito = cdao.EditCategory(id, categoria);

      return exito;
    }// fin de metodo add


  }// fin de clase
}// fin de namespace
