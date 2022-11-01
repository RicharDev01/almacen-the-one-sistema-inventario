
namespace Vistas
{
  partial class FDashboardAdmin
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDashboardAdmin));
      this.panelTitleBar = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.ibtnCerrar = new FontAwesome.Sharp.IconButton();
      this.ibtnMinimizar = new FontAwesome.Sharp.IconButton();
      this.panelMenuLateral = new System.Windows.Forms.Panel();
      this.ibtnCerrarSesion = new FontAwesome.Sharp.IconButton();
      this.ibtnCategorias = new FontAwesome.Sharp.IconButton();
      this.ibtnProveedores = new FontAwesome.Sharp.IconButton();
      this.ibtnProductos = new FontAwesome.Sharp.IconButton();
      this.ibtnCliente = new FontAwesome.Sharp.IconButton();
      this.ibtnPedidos = new FontAwesome.Sharp.IconButton();
      this.ibtnVentas = new FontAwesome.Sharp.IconButton();
      this.ibtnInventario = new FontAwesome.Sharp.IconButton();
      this.ibtnHome = new FontAwesome.Sharp.IconButton();
      this.pboxLogo = new System.Windows.Forms.PictureBox();
      this.panelAreaTrabajo = new System.Windows.Forms.Panel();
      this.panelTitleBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelMenuLateral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // panelTitleBar
      // 
      this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
      this.panelTitleBar.Controls.Add(this.pictureBox1);
      this.panelTitleBar.Controls.Add(this.ibtnCerrar);
      this.panelTitleBar.Controls.Add(this.ibtnMinimizar);
      this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
      this.panelTitleBar.Name = "panelTitleBar";
      this.panelTitleBar.Size = new System.Drawing.Size(1424, 30);
      this.panelTitleBar.TabIndex = 0;
      this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pictureBox1.Image = global::Vistas.Properties.Resources.favicon;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(55, 30);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // ibtnCerrar
      // 
      this.ibtnCerrar.FlatAppearance.BorderSize = 0;
      this.ibtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
      this.ibtnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(102)))), ((int)(((byte)(64)))));
      this.ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnCerrar.IconSize = 40;
      this.ibtnCerrar.Location = new System.Drawing.Point(1391, 0);
      this.ibtnCerrar.Name = "ibtnCerrar";
      this.ibtnCerrar.Size = new System.Drawing.Size(30, 30);
      this.ibtnCerrar.TabIndex = 1;
      this.ibtnCerrar.UseVisualStyleBackColor = true;
      this.ibtnCerrar.Click += new System.EventHandler(this.ibtnCerrar_Click);
      // 
      // ibtnMinimizar
      // 
      this.ibtnMinimizar.FlatAppearance.BorderSize = 0;
      this.ibtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
      this.ibtnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(225)))));
      this.ibtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnMinimizar.IconSize = 40;
      this.ibtnMinimizar.Location = new System.Drawing.Point(1355, 0);
      this.ibtnMinimizar.Name = "ibtnMinimizar";
      this.ibtnMinimizar.Size = new System.Drawing.Size(30, 30);
      this.ibtnMinimizar.TabIndex = 0;
      this.ibtnMinimizar.UseVisualStyleBackColor = true;
      this.ibtnMinimizar.Click += new System.EventHandler(this.ibtnMinimizar_Click);
      // 
      // panelMenuLateral
      // 
      this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.panelMenuLateral.Controls.Add(this.ibtnCerrarSesion);
      this.panelMenuLateral.Controls.Add(this.ibtnCategorias);
      this.panelMenuLateral.Controls.Add(this.ibtnProveedores);
      this.panelMenuLateral.Controls.Add(this.ibtnProductos);
      this.panelMenuLateral.Controls.Add(this.ibtnCliente);
      this.panelMenuLateral.Controls.Add(this.ibtnPedidos);
      this.panelMenuLateral.Controls.Add(this.ibtnVentas);
      this.panelMenuLateral.Controls.Add(this.ibtnInventario);
      this.panelMenuLateral.Controls.Add(this.ibtnHome);
      this.panelMenuLateral.Controls.Add(this.pboxLogo);
      this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelMenuLateral.Location = new System.Drawing.Point(0, 30);
      this.panelMenuLateral.Name = "panelMenuLateral";
      this.panelMenuLateral.Size = new System.Drawing.Size(250, 770);
      this.panelMenuLateral.TabIndex = 1;
      // 
      // ibtnCerrarSesion
      // 
      this.ibtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ibtnCerrarSesion.FlatAppearance.BorderSize = 0;
      this.ibtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnCerrarSesion.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnCerrarSesion.ForeColor = System.Drawing.Color.White;
      this.ibtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOut;
      this.ibtnCerrarSesion.IconColor = System.Drawing.Color.White;
      this.ibtnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnCerrarSesion.IconSize = 32;
      this.ibtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnCerrarSesion.Location = new System.Drawing.Point(0, 710);
      this.ibtnCerrarSesion.Name = "ibtnCerrarSesion";
      this.ibtnCerrarSesion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnCerrarSesion.Size = new System.Drawing.Size(250, 60);
      this.ibtnCerrarSesion.TabIndex = 9;
      this.ibtnCerrarSesion.Text = "Cerrar Sesión";
      this.ibtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnCerrarSesion.UseVisualStyleBackColor = true;
      this.ibtnCerrarSesion.Click += new System.EventHandler(this.ibtnCerrarSesion_Click);
      // 
      // ibtnCategorias
      // 
      this.ibtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnCategorias.FlatAppearance.BorderSize = 0;
      this.ibtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnCategorias.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnCategorias.ForeColor = System.Drawing.Color.White;
      this.ibtnCategorias.IconChar = FontAwesome.Sharp.IconChar.Shapes;
      this.ibtnCategorias.IconColor = System.Drawing.Color.White;
      this.ibtnCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnCategorias.IconSize = 32;
      this.ibtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnCategorias.Location = new System.Drawing.Point(0, 545);
      this.ibtnCategorias.Name = "ibtnCategorias";
      this.ibtnCategorias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnCategorias.Size = new System.Drawing.Size(250, 60);
      this.ibtnCategorias.TabIndex = 8;
      this.ibtnCategorias.Text = "Categorias";
      this.ibtnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnCategorias.UseVisualStyleBackColor = true;
      this.ibtnCategorias.Click += new System.EventHandler(this.ibtnCategorias_Click);
      // 
      // ibtnProveedores
      // 
      this.ibtnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnProveedores.FlatAppearance.BorderSize = 0;
      this.ibtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnProveedores.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnProveedores.ForeColor = System.Drawing.Color.White;
      this.ibtnProveedores.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
      this.ibtnProveedores.IconColor = System.Drawing.Color.White;
      this.ibtnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnProveedores.IconSize = 32;
      this.ibtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnProveedores.Location = new System.Drawing.Point(0, 485);
      this.ibtnProveedores.Name = "ibtnProveedores";
      this.ibtnProveedores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnProveedores.Size = new System.Drawing.Size(250, 60);
      this.ibtnProveedores.TabIndex = 7;
      this.ibtnProveedores.Text = "Proveedores";
      this.ibtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnProveedores.UseVisualStyleBackColor = true;
      this.ibtnProveedores.Click += new System.EventHandler(this.ibtnProveedores_Click);
      // 
      // ibtnProductos
      // 
      this.ibtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnProductos.FlatAppearance.BorderSize = 0;
      this.ibtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnProductos.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnProductos.ForeColor = System.Drawing.Color.White;
      this.ibtnProductos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
      this.ibtnProductos.IconColor = System.Drawing.Color.White;
      this.ibtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnProductos.IconSize = 32;
      this.ibtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnProductos.Location = new System.Drawing.Point(0, 425);
      this.ibtnProductos.Name = "ibtnProductos";
      this.ibtnProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnProductos.Size = new System.Drawing.Size(250, 60);
      this.ibtnProductos.TabIndex = 6;
      this.ibtnProductos.Text = "Productos";
      this.ibtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnProductos.UseVisualStyleBackColor = true;
      this.ibtnProductos.Click += new System.EventHandler(this.ibtnProductos_Click);
      // 
      // ibtnCliente
      // 
      this.ibtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnCliente.FlatAppearance.BorderSize = 0;
      this.ibtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnCliente.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnCliente.ForeColor = System.Drawing.Color.White;
      this.ibtnCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
      this.ibtnCliente.IconColor = System.Drawing.Color.White;
      this.ibtnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnCliente.IconSize = 32;
      this.ibtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnCliente.Location = new System.Drawing.Point(0, 365);
      this.ibtnCliente.Name = "ibtnCliente";
      this.ibtnCliente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnCliente.Size = new System.Drawing.Size(250, 60);
      this.ibtnCliente.TabIndex = 5;
      this.ibtnCliente.Text = "Clientes";
      this.ibtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnCliente.UseVisualStyleBackColor = true;
      this.ibtnCliente.Click += new System.EventHandler(this.ibtnCliente_Click);
      // 
      // ibtnPedidos
      // 
      this.ibtnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnPedidos.FlatAppearance.BorderSize = 0;
      this.ibtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnPedidos.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnPedidos.ForeColor = System.Drawing.Color.White;
      this.ibtnPedidos.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
      this.ibtnPedidos.IconColor = System.Drawing.Color.White;
      this.ibtnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnPedidos.IconSize = 32;
      this.ibtnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnPedidos.Location = new System.Drawing.Point(0, 305);
      this.ibtnPedidos.Name = "ibtnPedidos";
      this.ibtnPedidos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnPedidos.Size = new System.Drawing.Size(250, 60);
      this.ibtnPedidos.TabIndex = 4;
      this.ibtnPedidos.Text = "Pedidos";
      this.ibtnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnPedidos.UseVisualStyleBackColor = true;
      this.ibtnPedidos.Click += new System.EventHandler(this.ibtnPedidos_Click);
      // 
      // ibtnVentas
      // 
      this.ibtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnVentas.FlatAppearance.BorderSize = 0;
      this.ibtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnVentas.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnVentas.ForeColor = System.Drawing.Color.White;
      this.ibtnVentas.IconChar = FontAwesome.Sharp.IconChar.LineChart;
      this.ibtnVentas.IconColor = System.Drawing.Color.White;
      this.ibtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnVentas.IconSize = 32;
      this.ibtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnVentas.Location = new System.Drawing.Point(0, 245);
      this.ibtnVentas.Name = "ibtnVentas";
      this.ibtnVentas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnVentas.Size = new System.Drawing.Size(250, 60);
      this.ibtnVentas.TabIndex = 3;
      this.ibtnVentas.Text = "Ventas";
      this.ibtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnVentas.UseVisualStyleBackColor = true;
      this.ibtnVentas.Click += new System.EventHandler(this.ibtnVentas_Click);
      // 
      // ibtnInventario
      // 
      this.ibtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnInventario.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnInventario.FlatAppearance.BorderSize = 0;
      this.ibtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnInventario.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnInventario.ForeColor = System.Drawing.Color.White;
      this.ibtnInventario.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
      this.ibtnInventario.IconColor = System.Drawing.Color.White;
      this.ibtnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnInventario.IconSize = 32;
      this.ibtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnInventario.Location = new System.Drawing.Point(0, 185);
      this.ibtnInventario.Name = "ibtnInventario";
      this.ibtnInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnInventario.Size = new System.Drawing.Size(250, 60);
      this.ibtnInventario.TabIndex = 2;
      this.ibtnInventario.Text = "Inventario";
      this.ibtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnInventario.UseVisualStyleBackColor = true;
      this.ibtnInventario.Click += new System.EventHandler(this.ibtnInventario_Click);
      // 
      // ibtnHome
      // 
      this.ibtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
      this.ibtnHome.FlatAppearance.BorderSize = 0;
      this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnHome.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnHome.ForeColor = System.Drawing.Color.White;
      this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
      this.ibtnHome.IconColor = System.Drawing.Color.White;
      this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnHome.IconSize = 32;
      this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnHome.Location = new System.Drawing.Point(0, 125);
      this.ibtnHome.Name = "ibtnHome";
      this.ibtnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.ibtnHome.Size = new System.Drawing.Size(250, 60);
      this.ibtnHome.TabIndex = 1;
      this.ibtnHome.Text = "Home";
      this.ibtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnHome.UseVisualStyleBackColor = true;
      this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
      // 
      // pboxLogo
      // 
      this.pboxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.pboxLogo.Dock = System.Windows.Forms.DockStyle.Top;
      this.pboxLogo.Image = global::Vistas.Properties.Resources.logo_transparent;
      this.pboxLogo.Location = new System.Drawing.Point(0, 0);
      this.pboxLogo.Name = "pboxLogo";
      this.pboxLogo.Size = new System.Drawing.Size(250, 125);
      this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pboxLogo.TabIndex = 0;
      this.pboxLogo.TabStop = false;
      this.pboxLogo.Click += new System.EventHandler(this.pboxLogo_Click);
      // 
      // panelAreaTrabajo
      // 
      this.panelAreaTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.panelAreaTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelAreaTrabajo.Location = new System.Drawing.Point(250, 30);
      this.panelAreaTrabajo.Name = "panelAreaTrabajo";
      this.panelAreaTrabajo.Size = new System.Drawing.Size(1174, 770);
      this.panelAreaTrabajo.TabIndex = 2;
      // 
      // FDashboardAdmin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1424, 800);
      this.Controls.Add(this.panelAreaTrabajo);
      this.Controls.Add(this.panelMenuLateral);
      this.Controls.Add(this.panelTitleBar);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FDashboardAdmin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Dashboard De Administrador";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FDashboardAdmin_FormClosing);
      this.panelTitleBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelMenuLateral.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelTitleBar;
    private System.Windows.Forms.Panel panelMenuLateral;
    private FontAwesome.Sharp.IconButton ibtnCerrar;
    private FontAwesome.Sharp.IconButton ibtnMinimizar;
    private System.Windows.Forms.PictureBox pboxLogo;
    private System.Windows.Forms.PictureBox pictureBox1;
    private FontAwesome.Sharp.IconButton ibtnHome;
    private FontAwesome.Sharp.IconButton ibtnCerrarSesion;
    private FontAwesome.Sharp.IconButton ibtnCategorias;
    private FontAwesome.Sharp.IconButton ibtnProveedores;
    private FontAwesome.Sharp.IconButton ibtnProductos;
    private FontAwesome.Sharp.IconButton ibtnCliente;
    private FontAwesome.Sharp.IconButton ibtnPedidos;
    private FontAwesome.Sharp.IconButton ibtnVentas;
    private FontAwesome.Sharp.IconButton ibtnInventario;
    private System.Windows.Forms.Panel panelAreaTrabajo;
  }
}