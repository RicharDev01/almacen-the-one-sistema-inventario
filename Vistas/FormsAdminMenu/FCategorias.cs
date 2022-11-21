using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vistas.FormsAdminMenu
{
  public partial class FCategorias : Form
  {

    CategoriaController catControl = new CategoriaController();
    public FCategorias()
    {
      InitializeComponent();
    }

    private void FCategorias_Load(object sender, EventArgs e)
    {
      dgvCategorias.DataSource = catControl.getDataFillCategoria();
    } // metodo load

    private void inAddCategory_Click(object sender, EventArgs e)
    {
      bool error = false;

      if (!string.IsNullOrEmpty(inNameCategory.Texts))
      {
        // enviar nombre de la categoria
        //MessageBox.Show("No hay error, no esta vacio");
        bool res = catControl.AddCategory(inNameCategory.Texts);
        if (res)
          MessageBox.Show("Se registro la categoria con éxito!");
      }
      else
        error = true;

      if (error)
        errorProvider1.SetError(inNameCategory, "Campo vacio");
      else
        errorProvider1.Clear();

    }// fin de metodo inAddCategory_Click


    private void inNameCategory_KeyPress(object sender, KeyPressEventArgs e)
    {
      errorProvider1.Clear();
    }
  }// fin de clase
} // fin de namespace
