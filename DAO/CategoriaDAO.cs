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

    // variables globales
    Conexion conex = new Conexion();
    string query;

    // obtener la lista de categorias
    public MySqlDataAdapter getCategorias()
    {
      // Abro la conexion
      var con = conex.getConnection();
      con.Open();
      MySqlDataAdapter da = new MySqlDataAdapter();

      try
      {
        query = "SELECT id_categoria AS ID, nombre_categoria as CATEGORIA FROM tbl_categorias;";
        MySqlCommand cmd = new MySqlCommand(query,con);
        da.SelectCommand = cmd;
        
      }
      catch (MySqlException ex)
      {
        MessageBox.Show($" Error al mostrar categorias {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      

      return da;
    }

    // metodo de busqueda dinamica por categorias
    public MySqlDataAdapter SearchCategory(string searching)
    {
      // Abro la conexion
      var con = conex.getConnection();
      con.Open();

      MySqlDataAdapter da = new MySqlDataAdapter();
      try
      {
        query = $"SELECT id_categoria AS ID, nombre_categoria AS CATEGORIA \n" +
                $"FROM tbl_categorias WHERE nombre_categoria LIKE '{searching}%';";

        MySqlCommand cmd = new MySqlCommand(query, con);
        da.SelectCommand = cmd;

      }
      catch (MySqlException ex)
      {
        MessageBox.Show($"Error de SearchCategory {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return da;

    } // fin de metodo SearchCategory


    public bool AddCategory(string categoria)
    {
      // Abro la conexion
      var con = conex.getConnection();
      con.Open();
      bool exito = false;

      try
      {
        // escribo la consulta
        query = $"INSERT INTO tbl_categorias(nombre_categoria) VALUE(@categoria);";
        // agrego la consulta y la conexion, para poder ejecutar
        MySqlCommand cmd = new MySqlCommand(query, con);
        // asigno la variable y el valor de la misma
        cmd.Parameters.AddWithValue("@categoria", categoria);
        // ejecuto sin retorno
        cmd.ExecuteNonQuery();

        exito = true;
      }
      catch (MySqlException ex)
      {
        MessageBox.Show($"Error de conexion {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        exito = false;

      }
      finally
      {
        conex.getConnection().Close();
      }

      return exito;
    }// fin de metodo AddCategory

    public bool EditCategory(int id, string categoria)
    {
      // Abro la conexion
      var con = conex.getConnection();
      con.Open();
      bool exito = false;

      try
      {
        // escribo la consulta
        query = $"UPDATE tbl_categorias SET nombre_categoria = @categoria WHERE id_categoria = @id;";
        // agrego la consulta y la conexion, para poder ejecutar
        MySqlCommand cmd = new MySqlCommand(query, con);
        // asigno la variable y el valor de la misma
        cmd.Parameters.AddWithValue("@categoria", categoria);
        cmd.Parameters.AddWithValue("@id", id);
        // ejecuto sin retorno
        cmd.ExecuteNonQuery();

        exito = true;
      }
      catch (MySqlException ex)
      {
        MessageBox.Show($"Error de conexion {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        exito = false;

      }
      finally
      {
        conex.getConnection().Close();
      }

      return exito;
    }// fin de metodo EditCategory



  }// fin de clase dao
}// fin de namespace
