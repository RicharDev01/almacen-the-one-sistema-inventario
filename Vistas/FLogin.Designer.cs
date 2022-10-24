
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
      this.btnCerrar = new FontAwesome.Sharp.IconButton();
      this.btnMinimizar = new FontAwesome.Sharp.IconButton();
      this.panelBgInicio = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panelTitleBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
      this.panelBgInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
      this.panelBgInicio.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelBgInicio.Location = new System.Drawing.Point(0, 34);
      this.panelBgInicio.Name = "panelBgInicio";
      this.panelBgInicio.Size = new System.Drawing.Size(1280, 686);
      this.panelBgInicio.TabIndex = 1;
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
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelTitleBar;
    private FontAwesome.Sharp.IconButton btnCerrar;
    private FontAwesome.Sharp.IconButton btnMinimizar;
    private System.Windows.Forms.Panel panelBgInicio;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

