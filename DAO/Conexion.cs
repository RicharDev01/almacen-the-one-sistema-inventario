using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAO
{
  public class Conexion
  {

    // variables de conexion
    string user = "root";
    string pass = "database";
    string host = "localhost";
    string port = "3306";
    string databaseName = "almacen_the_one";
    string cadenaConexion;
    // declaro la variable de tipo conexion
    MySqlConnection con = null;

    public Conexion()
    {
      // cadena de conexion
      cadenaConexion = $"server={host};port={port};user={user};password={pass};database={databaseName}";
    }

    public MySqlConnection getConnection()
    {

      try
      {
        // asigno la conexion
        // @Param cadena de conexion
        con = new MySqlConnection(cadenaConexion);
        
      }
      catch (MySqlException ex)
      {
        MessageBox.Show($"Error en la conexion : >>> {ex}");
      }

      return con;

    }// fin de metodo getConnection



  }// fin de clase
}// fin namespace
