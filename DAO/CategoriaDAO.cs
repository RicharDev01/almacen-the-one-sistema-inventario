using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DAO
{
  public class CategoriaDAO
  {

    Conexion conex = new Conexion();

    public MySqlDataAdapter getCategorias()
    {
      // Abro la conexion
      var con = conex.getConnection();
      con.Open();
      MySqlDataAdapter sql = new MySqlDataAdapter();

      try
      {
        string query = "SELECT id_categoria AS ID, nombre_categoria as CATEGORIA FROM tbl_categorias;";
        MySqlCommand cmd = new MySqlCommand(query,con);
        sql.SelectCommand = cmd;
        
      }
      catch (MySqlException ex)
      {
        MessageBox.Show($" Error al mostrar categorias {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      

      return sql;
    }

  }// fin de clase dao
}// fin de namespace
