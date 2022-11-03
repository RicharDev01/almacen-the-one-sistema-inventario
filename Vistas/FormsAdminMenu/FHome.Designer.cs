
namespace Vistas.FormsAdminMenu
{
  partial class FHome
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHome));
      this.bannerWelcome = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.labelNameUser = new System.Windows.Forms.Label();
      this.ibtnFechaHora = new FontAwesome.Sharp.IconButton();
      this.pbxBanner = new System.Windows.Forms.PictureBox();
      this.cardMasVendido = new System.Windows.Forms.Panel();
      this.labelCountProduct = new System.Windows.Forms.Label();
      this.labelNameProduct = new System.Windows.Forms.Label();
      this.chartProdMasVendido = new LiveCharts.WinForms.CartesianChart();
      this.labelCardTitle = new System.Windows.Forms.Label();
      this.panelMenosVendido = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.chartProdMenosVendido = new LiveCharts.WinForms.CartesianChart();
      this.labelCardTitleMenos = new System.Windows.Forms.Label();
      this.timerActualizarFecha = new System.Windows.Forms.Timer(this.components);
      this.bannerWelcome.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
      this.cardMasVendido.SuspendLayout();
      this.panelMenosVendido.SuspendLayout();
      this.SuspendLayout();
      // 
      // bannerWelcome
      // 
      this.bannerWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.bannerWelcome.Controls.Add(this.label1);
      this.bannerWelcome.Controls.Add(this.labelNameUser);
      this.bannerWelcome.Controls.Add(this.ibtnFechaHora);
      this.bannerWelcome.Controls.Add(this.pbxBanner);
      this.bannerWelcome.Dock = System.Windows.Forms.DockStyle.Top;
      this.bannerWelcome.Location = new System.Drawing.Point(0, 0);
      this.bannerWelcome.Name = "bannerWelcome";
      this.bannerWelcome.Size = new System.Drawing.Size(1239, 177);
      this.bannerWelcome.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.label1.Location = new System.Drawing.Point(76, 134);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(344, 28);
      this.label1.TabIndex = 2;
      this.label1.Text = "Estas son las novedadaes del día Martes";
      // 
      // labelNameUser
      // 
      this.labelNameUser.AutoSize = true;
      this.labelNameUser.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.labelNameUser.Location = new System.Drawing.Point(76, 98);
      this.labelNameUser.Name = "labelNameUser";
      this.labelNameUser.Size = new System.Drawing.Size(265, 36);
      this.labelNameUser.TabIndex = 2;
      this.labelNameUser.Text = "Buen Día Ricardo Pineda";
      // 
      // ibtnFechaHora
      // 
      this.ibtnFechaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(133)))), ((int)(((byte)(225)))));
      this.ibtnFechaHora.FlatAppearance.BorderSize = 0;
      this.ibtnFechaHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ibtnFechaHora.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.ibtnFechaHora.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
      this.ibtnFechaHora.IconColor = System.Drawing.Color.White;
      this.ibtnFechaHora.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.ibtnFechaHora.IconSize = 30;
      this.ibtnFechaHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ibtnFechaHora.Location = new System.Drawing.Point(76, 23);
      this.ibtnFechaHora.Name = "ibtnFechaHora";
      this.ibtnFechaHora.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.ibtnFechaHora.Size = new System.Drawing.Size(419, 38);
      this.ibtnFechaHora.TabIndex = 1;
      this.ibtnFechaHora.Text = "Martes 01 de Noviembre 2022        8:50pm";
      this.ibtnFechaHora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ibtnFechaHora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.ibtnFechaHora.UseVisualStyleBackColor = false;
      // 
      // pbxBanner
      // 
      this.pbxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbxBanner.Image")));
      this.pbxBanner.Location = new System.Drawing.Point(777, 0);
      this.pbxBanner.Name = "pbxBanner";
      this.pbxBanner.Size = new System.Drawing.Size(308, 174);
      this.pbxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbxBanner.TabIndex = 0;
      this.pbxBanner.TabStop = false;
      // 
      // cardMasVendido
      // 
      this.cardMasVendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
      this.cardMasVendido.Controls.Add(this.labelCountProduct);
      this.cardMasVendido.Controls.Add(this.labelNameProduct);
      this.cardMasVendido.Controls.Add(this.chartProdMasVendido);
      this.cardMasVendido.Controls.Add(this.labelCardTitle);
      this.cardMasVendido.Location = new System.Drawing.Point(191, 198);
      this.cardMasVendido.Name = "cardMasVendido";
      this.cardMasVendido.Size = new System.Drawing.Size(275, 250);
      this.cardMasVendido.TabIndex = 2;
      // 
      // labelCountProduct
      // 
      this.labelCountProduct.AutoSize = true;
      this.labelCountProduct.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.labelCountProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(148)))));
      this.labelCountProduct.Location = new System.Drawing.Point(106, 69);
      this.labelCountProduct.Name = "labelCountProduct";
      this.labelCountProduct.Size = new System.Drawing.Size(47, 36);
      this.labelCountProduct.TabIndex = 3;
      this.labelCountProduct.Text = "125";
      // 
      // labelNameProduct
      // 
      this.labelNameProduct.AutoSize = true;
      this.labelNameProduct.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.labelNameProduct.Location = new System.Drawing.Point(74, 37);
      this.labelNameProduct.Name = "labelNameProduct";
      this.labelNameProduct.Size = new System.Drawing.Size(110, 22);
      this.labelNameProduct.TabIndex = 2;
      this.labelNameProduct.Text = "Mouse Strike Me";
      // 
      // chartProdMasVendido
      // 
      this.chartProdMasVendido.Location = new System.Drawing.Point(3, 108);
      this.chartProdMasVendido.Name = "chartProdMasVendido";
      this.chartProdMasVendido.Size = new System.Drawing.Size(269, 139);
      this.chartProdMasVendido.TabIndex = 1;
      this.chartProdMasVendido.Text = "Producto Mas vendido";
      // 
      // labelCardTitle
      // 
      this.labelCardTitle.AutoSize = true;
      this.labelCardTitle.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.labelCardTitle.Location = new System.Drawing.Point(45, 0);
      this.labelCardTitle.Name = "labelCardTitle";
      this.labelCardTitle.Size = new System.Drawing.Size(176, 25);
      this.labelCardTitle.TabIndex = 0;
      this.labelCardTitle.Text = "Producto Más Vendido";
      // 
      // panelMenosVendido
      // 
      this.panelMenosVendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
      this.panelMenosVendido.Controls.Add(this.label2);
      this.panelMenosVendido.Controls.Add(this.label3);
      this.panelMenosVendido.Controls.Add(this.chartProdMenosVendido);
      this.panelMenosVendido.Controls.Add(this.labelCardTitleMenos);
      this.panelMenosVendido.Location = new System.Drawing.Point(777, 198);
      this.panelMenosVendido.Name = "panelMenosVendido";
      this.panelMenosVendido.Size = new System.Drawing.Size(275, 250);
      this.panelMenosVendido.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(102)))), ((int)(((byte)(64)))));
      this.label2.Location = new System.Drawing.Point(114, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 36);
      this.label2.TabIndex = 3;
      this.label2.Text = "25";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.label3.Location = new System.Drawing.Point(74, 37);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(125, 22);
      this.label3.TabIndex = 2;
      this.label3.Text = "Monitor 24\" 3D xyz";
      // 
      // chartProdMenosVendido
      // 
      this.chartProdMenosVendido.Location = new System.Drawing.Point(3, 108);
      this.chartProdMenosVendido.Name = "chartProdMenosVendido";
      this.chartProdMenosVendido.Size = new System.Drawing.Size(269, 139);
      this.chartProdMenosVendido.TabIndex = 1;
      this.chartProdMenosVendido.Text = "Producto Mas vendido";
      // 
      // labelCardTitleMenos
      // 
      this.labelCardTitleMenos.AutoSize = true;
      this.labelCardTitleMenos.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.labelCardTitleMenos.Location = new System.Drawing.Point(45, 0);
      this.labelCardTitleMenos.Name = "labelCardTitleMenos";
      this.labelCardTitleMenos.Size = new System.Drawing.Size(193, 25);
      this.labelCardTitleMenos.TabIndex = 0;
      this.labelCardTitleMenos.Text = "Producto Menos Vendido";
      // 
      // timerActualizarFecha
      // 
      this.timerActualizarFecha.Interval = 1000;
      this.timerActualizarFecha.Tick += new System.EventHandler(this.timerActualizarFecha_Tick);
      // 
      // FHome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.ClientSize = new System.Drawing.Size(1239, 731);
      this.Controls.Add(this.panelMenosVendido);
      this.Controls.Add(this.cardMasVendido);
      this.Controls.Add(this.bannerWelcome);
      this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "FHome";
      this.Text = "FHome";
      this.Load += new System.EventHandler(this.FHome_Load);
      this.bannerWelcome.ResumeLayout(false);
      this.bannerWelcome.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
      this.cardMasVendido.ResumeLayout(false);
      this.cardMasVendido.PerformLayout();
      this.panelMenosVendido.ResumeLayout(false);
      this.panelMenosVendido.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel bannerWelcome;
    private FontAwesome.Sharp.IconButton ibtnFechaHora;
    private System.Windows.Forms.PictureBox pbxBanner;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelNameUser;
    private System.Windows.Forms.Panel cardMasVendido;
    private System.Windows.Forms.Label labelCardTitle;
    private LiveCharts.WinForms.CartesianChart chartProdMasVendido;
    private System.Windows.Forms.Label labelNameProduct;
    private System.Windows.Forms.Label labelCountProduct;
    private System.Windows.Forms.Panel panelMenosVendido;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private LiveCharts.WinForms.CartesianChart chartProdMenosVendido;
    private System.Windows.Forms.Label labelCardTitleMenos;
    private System.Windows.Forms.Timer timerActualizarFecha;
  }
}