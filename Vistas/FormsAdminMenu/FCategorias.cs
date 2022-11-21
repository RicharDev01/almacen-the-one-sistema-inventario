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

    }// fin de metodo inAddCategory_Click

  }// fin de clase
} // fin de namespace
