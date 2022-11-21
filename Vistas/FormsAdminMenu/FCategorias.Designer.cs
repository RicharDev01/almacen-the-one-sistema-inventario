
namespace Vistas.FormsAdminMenu
{
  partial class FCategorias
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.inNameCategory = new Vistas.customControls.CustomInput();
      this.labelNameCategory = new System.Windows.Forms.Label();
      this.inAddCategory = new FontAwesome.Sharp.IconButton();
      this.dgvCategorias = new System.Windows.Forms.DataGridView();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.label1.Font = new System.Drawing.Font("Poppins", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(552, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(223, 62);
      this.label1.TabIndex = 0;
      this.label1.Text = "Categorias";
      // 
      // inNameCategory
      // 
      this.inNameCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.inNameCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.inNameCategory.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
      this.inNameCategory.BorderSize = 2;
      this.inNameCategory.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.inNameCategory.ForeColor = System.Drawing.Color.White;
      this.inNameCategory.Location = new System.Drawing.Point(399, 184);
      this.inNameCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inNameCategory.Multiline = false;
      this.inNameCategory.Name = "inNameCategory";
      this.inNameCategory.Padding = new System.Windows.Forms.Padding(7);
      this.inNameCategory.PasswordChar = false;
      this.inNameCategory.Size = new System.Drawing.Size(250, 40);
      this.inNameCategory.TabIndex = 1;
      this.inNameCategory.Texts = "";
      this.inNameCategory.UnderlinedStyle = false;
      this.inNameCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inNameCategory_KeyPress);
      // 
      // labelNameCategory
      // 
      this.labelNameCategory.AutoSize = true;
      this.labelNameCategory.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labelNameCategory.Location = new System.Drawing.Point(399, 152);
      this.labelNameCategory.Name = "labelNameCategory";
      this.labelNameCategory.Size = new System.Drawing.Size(186, 28);
      this.labelNameCategory.TabIndex = 2;
      this.labelNameCategory.Text = "Nombre de Categoria";
      // 
      // inAddCategory
      // 
      this.inAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.inAddCategory.FlatAppearance.BorderSize = 0;
      this.inAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.inAddCategory.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.inAddCategory.IconChar = FontAwesome.Sharp.IconChar.None;
      this.inAddCategory.IconColor = System.Drawing.Color.Black;
      this.inAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.inAddCategory.Location = new System.Drawing.Point(690, 184);
      this.inAddCategory.Name = "inAddCategory";
      this.inAddCategory.Size = new System.Drawing.Size(178, 40);
      this.inAddCategory.TabIndex = 2;
      this.inAddCategory.Text = "Agregar";
      this.inAddCategory.UseVisualStyleBackColor = false;
      this.inAddCategory.Click += new System.EventHandler(this.inAddCategory_Click);
      // 
      // dgvCategorias
      // 
      this.dgvCategorias.AllowUserToAddRows = false;
      this.dgvCategorias.AllowUserToDeleteRows = false;
      this.dgvCategorias.AllowUserToResizeColumns = false;
      this.dgvCategorias.AllowUserToResizeRows = false;
      this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
      this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle1;
      this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
      this.dgvCategorias.Location = new System.Drawing.Point(432, 297);
      this.dgvCategorias.Name = "dgvCategorias";
      this.dgvCategorias.RowTemplate.Height = 25;
      this.dgvCategorias.Size = new System.Drawing.Size(410, 257);
      this.dgvCategorias.TabIndex = 3;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // FCategorias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.ClientSize = new System.Drawing.Size(1243, 660);
      this.Controls.Add(this.dgvCategorias);
      this.Controls.Add(this.inAddCategory);
      this.Controls.Add(this.labelNameCategory);
      this.Controls.Add(this.inNameCategory);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.Name = "FCategorias";
      this.Text = "FCategorias";
      this.Load += new System.EventHandler(this.FCategorias_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private customControls.CustomInput inNameCategory;
    private System.Windows.Forms.Label labelNameCategory;
    private FontAwesome.Sharp.IconButton inAddCategory;
    private System.Windows.Forms.DataGridView dgvCategorias;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}