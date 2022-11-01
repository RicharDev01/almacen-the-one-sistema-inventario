using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
  public partial class FLogin : Form
  {
    public FLogin()
    {
      InitializeComponent();
    }

    // para verificar si exite la instancia o no
    // si existe, que retorne la misma, sino que la cree
    public static FLogin _instanciaFLogin;

    public static FLogin GetInstanciaFLogin()
    {
      if (_instanciaFLogin == null)
      {
        _instanciaFLogin = new FLogin();
      }

      return _instanciaFLogin;
    }

    // creo un struct para guardar la paleta de colores
    struct PaletaDeColores
    {
      public static Color bgColor = Color.FromArgb(30,30,30); 
      public static Color bgColor2 = Color.FromArgb(61, 59, 79);   
      public static Color bgColorAccent = Color.FromArgb(82, 81, 96);   
      public static Color mainColor = Color.FromArgb(87,86,204);  
      public static Color secundaryColor = Color.FromArgb(129, 133, 225);   
      public static Color white = Color.FromArgb(255,255,255);
      public static Color seccesssColor = Color.FromArgb(0, 178, 148);
      public static Color alertColor = Color.FromArgb(209, 102, 64);
      public static Color activeColor = Color.FromArgb(223, 126, 231);
      public static Color textColor = Color.FromArgb(170, 168, 195);
      public static Color infoColor = Color.FromArgb(103, 72, 213); 
    }

    //Esto me ayuda a dar movimiento de arrastre al form
    // sin la barra de widows que viene por defecto
    // de esta manera puedo personalizar mi interfaz
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnMinimizar_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnIniciarSession_Click(object sender, EventArgs e)
    {
      
      this.Hide();
      FDashboardAdmin.GetInstanciaFDashboardAdmin().Show();
    }

    private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
