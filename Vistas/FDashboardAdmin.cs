using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Vistas.FormsAdminMenu;

namespace Vistas
{  
  public partial class FDashboardAdmin : Form
  {

    //Fields
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;

    public FDashboardAdmin()
    {
      InitializeComponent();

      leftBorderBtn = new Panel();
      leftBorderBtn.Size = new Size(7, 60);
      panelMenuLateral.Controls.Add(leftBorderBtn);
      //Form
      this.DoubleBuffered = true;
    }

    // para verificar si exite la instancia o no
    // si existe, que retorne la misma, sino que la cree
    public static FDashboardAdmin _instanciaFDashboardAdmin;

    public static FDashboardAdmin GetInstanciaFDashboardAdmin()
    {
      if (_instanciaFDashboardAdmin == null)
      {
        _instanciaFDashboardAdmin = new FDashboardAdmin();
      }

      return _instanciaFDashboardAdmin;
    }

    //Esto me ayuda a dar movimiento de arrastre al form
    // sin la barra de widows que viene por defecto
    // de esta manera puedo personalizar mi interfaz
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    struct PaletaDeColores
    {
      public static Color bgColor = Color.FromArgb(30, 30, 30);
      public static Color bgColor2 = Color.FromArgb(61, 59, 79);
      public static Color bgColorAccent = Color.FromArgb(82, 81, 96);
      public static Color mainColor = Color.FromArgb(87, 86, 204);
      public static Color secundaryColor = Color.FromArgb(129, 133, 225);
      public static Color white = Color.FromArgb(255, 255, 255);
      public static Color seccesssColor = Color.FromArgb(0, 178, 148);
      public static Color alertColor = Color.FromArgb(209, 102, 64);
      public static Color activeColor = Color.FromArgb(223, 126, 231);
      public static Color textColor = Color.FromArgb(170, 168, 195);
      public static Color infoColor = Color.FromArgb(103, 72, 213);
      public static Color warningColor = Color.FromArgb(255, 177, 66);
    }


    //Methods
    private void ActivateButton(object senderBtn, Color color)
    {
      if (senderBtn != null)
      {
        DisableButton();
        //Button
        currentBtn = (IconButton)senderBtn;
        currentBtn.BackColor = Color.FromArgb(37, 36, 81); // active color
        currentBtn.ForeColor = color;
        currentBtn.IconColor = color;

        leftBorderBtn.BackColor = color;
        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        leftBorderBtn.Visible = true;
        leftBorderBtn.BringToFront();

      }
    }

    private void DisableButton()
    {
      if (currentBtn != null)
      {
        currentBtn.BackColor = PaletaDeColores.mainColor;
        currentBtn.ForeColor = Color.White;
        currentBtn.IconColor = Color.White;
      }
    }

    private void OpenChildForm(Form childForm)
    {
      //open only form
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      currentChildForm = childForm;
      //End
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      panelAreaTrabajo.Controls.Add(childForm);
      panelAreaTrabajo.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
    }


    private void ibtnCerrar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void ibtnMinimizar_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }


    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void FDashboardAdmin_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    /* BOTONES DE MENU LATERAL */

    private void ibtnHome_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FHome());
    }

    private void ibtnInventario_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FInventario());
    }

    private void ibtnVentas_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FVentas());
    }

    private void ibtnPedidos_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FPedidos());
    }

    private void ibtnCliente_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FClientes());
    }

    private void ibtnProductos_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FProductos());
    }

    private void ibtnProveedores_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FProveedores());
    }

    private void ibtnCategorias_Click(object sender, EventArgs e)
    {
      ActivateButton(sender, PaletaDeColores.activeColor);
      OpenChildForm(new FCategorias());
    }

    private void ibtnCerrarSesion_Click(object sender, EventArgs e)
    {
      FLogin.GetInstanciaFLogin().Show();
      this.Hide();
    }

    private void Reset()
    {
      DisableButton();
      leftBorderBtn.Visible = false;
    }

    private void pboxLogo_Click(object sender, EventArgs e)
    {
      //if (currentChildForm != null)
      //{
      //  currentChildForm.Close();
      //}
      Reset();
    }

    private void FDashboardAdmin_Load(object sender, EventArgs e)
    {
      //ActivateButton((IconButton)sender, PaletaDeColores.activeColor);

      OpenChildForm(new FHome());
    }
  }
}
