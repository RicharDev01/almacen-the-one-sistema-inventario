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

    private void inSearchCategory__TextChanged(object sender, EventArgs e)
    {
      var data = catControl.SearchCategory(inSearchCategory.Texts);
      dgvCategorias.DataSource = data;
    }


    private void inAddCategory_Click(object sender, EventArgs e)
    {
      bool error = false;

      if (!string.IsNullOrEmpty(inNameCategory.Texts))
      {
        // enviar nombre de la categoria
        //MessageBox.Show("No hay error, no esta vacio");
        bool res = catControl.AddCategory(inNameCategory.Texts);
        if (res)
        {
          MessageBox.Show("Se registro la categoria con éxito!");
          dgvCategorias.DataSource = catControl.getDataFillCategoria();
        }
      }
      else
        error = true;

      if (error)
        errorProvider1.SetError(inNameCategory, "Campo vacio");
      else
        errorProvider1.Clear();

    }// fin de metodo inAddCategory_Click

    private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value);
      string name = (string) dgvCategorias.SelectedRows[0].Cells[1].Value;

      inEditCategory.Texts = name;

    }// fin de metodo dgvCategorias_CellClick

    // TODO: debo de hacer que se resiva el id y nombre desde el dataGridView
    public void EditCategory(int id, string name) 
    {
      bool res = false;

      if (!string.IsNullOrEmpty(inEditCategory.Texts))
      {
        res = catControl.EditCategory(id, name);
      }

      if (res)
        MessageBox.Show("Se Actualizo con exito!");
      else
        MessageBox.Show("hubo un error al actualizar");
    }

    private void btnEditCategory_Click(object sender, EventArgs e)
    {
      int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value);
      EditCategory(id, inEditCategory.Texts);
      dgvCategorias.DataSource = catControl.getDataFillCategoria();
    }
  }// fin de clase
} // fin de namespace
