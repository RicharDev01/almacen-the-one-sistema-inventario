using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Entities;

namespace DAO
{
  public class MainScreenDAO
  {

    Conexion conex = new Conexion();
    

    // metodo que realiza la consulta a la db
    public List<string> ProductoMasVendido() 
    {
      List<string> listaProducto = new List<string>();

      // abro la conexion
      var con = conex.getConnection();
      con.Open();

      try
      {
        
        // la consulta a realizar a db
        string query = $"SELECT p.id_producto AS ID, SUM(cantidad_compra) AS CANTIDAD, p.nombre_producto AS NOMBRE \n" +
                          $"FROM tbl_ventas v \n" +
                        $"INNER JOIN tbl_productos p ON v.producto_id = p.id_producto \n" +
                          $"WHERE producto_id GROUP BY producto_id ORDER BY CANTIDAD DESC LIMIT 1;";

        // la clase que me ayuda a ejecutar las consultas
        MySqlCommand cmd = new MySqlCommand(query, con);
        
        // el metodo que me proporciona la informacion obtenida de la db
        MySqlDataReader dataReader = cmd.ExecuteReader();
        
        

        while (dataReader.Read())
        {
          string id = dataReader["ID"].ToString();
          string cantidad = dataReader["CANTIDAD"].ToString();
          string nombre = dataReader["NOMBRE"].ToString();
          listaProducto.Add(id);
          listaProducto.Add(cantidad);
          listaProducto.Add(nombre);
        }


      }
      catch (MySqlException ex)
      {

        MessageBox.Show($"Error de consulta : >>> {ex}");
      }
      finally
      {
        conex.getConnection().Close();
      }

      return listaProducto;

    }// fin de metodo

    // metodo que realiza la consulta a la db
    public List<string> ProductoMenosVendido()
    {
      List<string> listaProducto = new List<string>();

      // abro la conexion
      var con = conex.getConnection();
      con.Open();

      try
      {

        // la consulta a realizar a db
        string query = $"SELECT p.id_producto AS ID, SUM(cantidad_compra) AS CANTIDAD, p.nombre_producto AS NOMBRE \n" +
                          $"FROM tbl_ventas v \n" +
                        $"INNER JOIN tbl_productos p ON v.producto_id = p.id_producto \n" +
                          $"WHERE producto_id GROUP BY producto_id ORDER BY CANTIDAD ASC LIMIT 1;";

        // la clase que me ayuda a ejecutar las consultas
        MySqlCommand cmd = new MySqlCommand(query, con);

        // el metodo que me proporciona la informacion obtenida de la db
        MySqlDataReader dataReader = cmd.ExecuteReader();



        while (dataReader.Read())
        {
          string id = dataReader["ID"].ToString();
          string cantidad = dataReader["CANTIDAD"].ToString();
          string nombre = dataReader["NOMBRE"].ToString();
          listaProducto.Add(id);
          listaProducto.Add(cantidad);
          listaProducto.Add(nombre);
        }


      }
      catch (MySqlException ex)
      {

        MessageBox.Show($"Error de consulta : >>> {ex}");
      }
      finally
      {
        conex.getConnection().Close();
      }

      return listaProducto;

    }// fin de metodo


  }// fin de clase
}// fin de namespace
