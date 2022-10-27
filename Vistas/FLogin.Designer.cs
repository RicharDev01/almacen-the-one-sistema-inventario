
namespace Vistas
{
  partial class FLogin
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
      this.panelTitleBar = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnCerrar = new FontAwesome.Sharp.IconButton();
      this.btnMinimizar = new FontAwesome.Sharp.IconButton();
      this.panelBgInicio = new System.Windows.Forms.Panel();
      this.panelLogin = new System.Windows.Forms.Panel();
      this.btnIniciarSession = new System.Windows.Forms.Button();
      this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
      this.labelPassword = new System.Windows.Forms.Label();
      this.iconUsuario = new FontAwesome.Sharp.IconPictureBox();
      this.labelUsuario = new System.Windows.Forms.Label();
      this.inPassword = new Vistas.customControls.CustomInput();
      this.inUsuario = new Vistas.customControls.CustomInput();
      this.labelTitle = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.panelTitleBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelBgInicio.SuspendLayout();
      this.panelLogin.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconUsuario)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // panelTitleBar
      // 
      this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.panelTitleBar.Controls.Add(this.pictureBox1);
      this.panelTitleBar.Controls.Add(this.btnCerrar);
      this.panelTitleBar.Controls.Add(this.btnMinimizar);
      this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
      this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panelTitleBar.Name = "panelTitleBar";
      this.panelTitleBar.Size = new System.Drawing.Size(1280, 34);
      this.panelTitleBar.TabIndex = 0;
      this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(42, 34);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // btnCerrar
      // 
      this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
      this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnCerrar.FlatAppearance.BorderSize = 0;
      this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
      this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
      this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(102)))), ((int)(((byte)(64)))));
      this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btnCerrar.IconSize = 38;
      this.btnCerrar.Location = new System.Drawing.Point(1244, 0);
      this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(36, 34);
      this.btnCerrar.TabIndex = 2;
      this.btnCerrar.UseVisualStyleBackColor = false;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
      this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
      this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(225)))));
      this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btnMinimizar.IconSize = 38;
      this.btnMinimizar.Location = new System.Drawing.Point(1200, 0);
      this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnMinimizar.Name = "btnMinimizar";
      this.btnMinimizar.Size = new System.Drawing.Size(36, 34);
      this.btnMinimizar.TabIndex = 1;
      this.btnMinimizar.UseVisualStyleBackColor = false;
      this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
      // 
      // panelBgInicio
      // 
      this.panelBgInicio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.panelBgInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
      this.panelBgInicio.Controls.Add(this.panelLogin);
      this.panelBgInicio.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelBgInicio.Location = new System.Drawing.Point(0, 34);
      this.panelBgInicio.Name = "panelBgInicio";
      this.panelBgInicio.Size = new System.Drawing.Size(1280, 686);
      this.panelBgInicio.TabIndex = 1;
      // 
      // panelLogin
      // 
      this.panelLogin.BackColor = System.Drawing.Color.Transparent;
      this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelLogin.Controls.Add(this.btnIniciarSession);
      this.panelLogin.Controls.Add(this.iconPassword);
      this.panelLogin.Controls.Add(this.labelPassword);
      this.panelLogin.Controls.Add(this.iconUsuario);
      this.panelLogin.Controls.Add(this.labelUsuario);
      this.panelLogin.Controls.Add(this.inPassword);
      this.panelLogin.Controls.Add(this.inUsuario);
      this.panelLogin.Controls.Add(this.labelTitle);
      this.panelLogin.Controls.Add(this.pictureBox2);
      this.panelLogin.Location = new System.Drawing.Point(380, 34);
      this.panelLogin.Name = "panelLogin";
      this.panelLogin.Size = new System.Drawing.Size(480, 600);
      this.panelLogin.TabIndex = 0;
      // 
      // btnIniciarSession
      // 
      this.btnIniciarSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.btnIniciarSession.FlatAppearance.BorderSize = 0;
      this.btnIniciarSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnIniciarSession.Location = new System.Drawing.Point(92, 457);
      this.btnIniciarSession.Name = "btnIniciarSession";
      this.btnIniciarSession.Size = new System.Drawing.Size(278, 40);
      this.btnIniciarSession.TabIndex = 5;
      this.btnIniciarSession.Text = "INICIAR SESIÓN";
      this.btnIniciarSession.UseVisualStyleBackColor = false;
      // 
      // iconPassword
      // 
      this.iconPassword.BackColor = System.Drawing.Color.Transparent;
      this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
      this.iconPassword.IconColor = System.Drawing.Color.White;
      this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconPassword.IconSize = 28;
      this.iconPassword.Location = new System.Drawing.Point(92, 348);
      this.iconPassword.Name = "iconPassword";
      this.iconPassword.Size = new System.Drawing.Size(32, 28);
      this.iconPassword.TabIndex = 4;
      this.iconPassword.TabStop = false;
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Location = new System.Drawing.Point(121, 348);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(117, 28);
      this.labelPassword.TabIndex = 3;
      this.labelPassword.Text = "CONTRASEÑA";
      // 
      // iconUsuario
      // 
      this.iconUsuario.BackColor = System.Drawing.Color.Transparent;
      this.iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
      this.iconUsuario.IconColor = System.Drawing.Color.White;
      this.iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconUsuario.IconSize = 28;
      this.iconUsuario.Location = new System.Drawing.Point(92, 251);
      this.iconUsuario.Name = "iconUsuario";
      this.iconUsuario.Size = new System.Drawing.Size(32, 28);
      this.iconUsuario.TabIndex = 4;
      this.iconUsuario.TabStop = false;
      // 
      // labelUsuario
      // 
      this.labelUsuario.AutoSize = true;
      this.labelUsuario.Location = new System.Drawing.Point(121, 251);
      this.labelUsuario.Name = "labelUsuario";
      this.labelUsuario.Size = new System.Drawing.Size(81, 28);
      this.labelUsuario.TabIndex = 3;
      this.labelUsuario.Text = "USUARIO";
      // 
      // inPassword
      // 
      this.inPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.inPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.inPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
      this.inPassword.BorderSize = 2;
      this.inPassword.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.inPassword.ForeColor = System.Drawing.Color.White;
      this.inPassword.Location = new System.Drawing.Point(92, 383);
      this.inPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inPassword.Multiline = false;
      this.inPassword.Name = "inPassword";
      this.inPassword.Padding = new System.Windows.Forms.Padding(7);
      this.inPassword.PasswordChar = true;
      this.inPassword.Size = new System.Drawing.Size(278, 34);
      this.inPassword.TabIndex = 2;
      this.inPassword.Texts = "";
      this.inPassword.UnderlinedStyle = true;
      // 
      // inUsuario
      // 
      this.inUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.inUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.inUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
      this.inUsuario.BorderSize = 2;
      this.inUsuario.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.inUsuario.ForeColor = System.Drawing.Color.White;
      this.inUsuario.Location = new System.Drawing.Point(92, 283);
      this.inUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inUsuario.Multiline = false;
      this.inUsuario.Name = "inUsuario";
      this.inUsuario.Padding = new System.Windows.Forms.Padding(7);
      this.inUsuario.PasswordChar = false;
      this.inUsuario.Size = new System.Drawing.Size(278, 34);
      this.inUsuario.TabIndex = 2;
      this.inUsuario.Texts = "";
      this.inUsuario.UnderlinedStyle = true;
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.labelTitle.Location = new System.Drawing.Point(92, 176);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(278, 53);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "INICIO DE SESIÓN";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::Vistas.Properties.Resources.logo_transparent;
      this.pictureBox2.Location = new System.Drawing.Point(143, 17);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(179, 156);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 0;
      this.pictureBox2.TabStop = false;
      // 
      // FLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.panelBgInicio);
      this.Controls.Add(this.panelTitleBar);
      this.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Inicio de Sesión";
      this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(148)))));
      this.panelTitleBar.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelBgInicio.ResumeLayout(false);
      this.panelLogin.ResumeLayout(false);
      this.panelLogin.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconUsuario)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelTitleBar;
    private FontAwesome.Sharp.IconButton btnCerrar;
    private FontAwesome.Sharp.IconButton btnMinimizar;
    private System.Windows.Forms.Panel panelBgInicio;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panelLogin;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Button btnIniciarSession;
    private FontAwesome.Sharp.IconPictureBox iconPassword;
    private System.Windows.Forms.Label labelPassword;
    private FontAwesome.Sharp.IconPictureBox iconUsuario;
    private System.Windows.Forms.Label labelUsuario;
    private customControls.CustomInput inPassword;
    private customControls.CustomInput inUsuario;
  }
}

