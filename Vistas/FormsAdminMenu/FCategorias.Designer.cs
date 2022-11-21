
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
      this.btnAddCategory = new FontAwesome.Sharp.IconButton();
      this.dgvCategorias = new System.Windows.Forms.DataGridView();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.inSearchCategory = new Vistas.customControls.CustomInput();
      this.btnSearchCategory = new FontAwesome.Sharp.IconButton();
      this.btnEditCategory = new FontAwesome.Sharp.IconButton();
      this.iconButton1 = new FontAwesome.Sharp.IconButton();
      this.inEditCategory = new Vistas.customControls.CustomInput();
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
      this.inNameCategory.Location = new System.Drawing.Point(798, 183);
      this.inNameCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inNameCategory.Multiline = false;
      this.inNameCategory.Name = "inNameCategory";
      this.inNameCategory.Padding = new System.Windows.Forms.Padding(7);
      this.inNameCategory.PasswordChar = false;
      this.inNameCategory.Size = new System.Drawing.Size(250, 40);
      this.inNameCategory.TabIndex = 1;
      this.inNameCategory.Texts = "";
      this.inNameCategory.UnderlinedStyle = false;
      // 
      // labelNameCategory
      // 
      this.labelNameCategory.AutoSize = true;
      this.labelNameCategory.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.labelNameCategory.Location = new System.Drawing.Point(798, 151);
      this.labelNameCategory.Name = "labelNameCategory";
      this.labelNameCategory.Size = new System.Drawing.Size(186, 28);
      this.labelNameCategory.TabIndex = 2;
      this.labelNameCategory.Text = "Nombre de Categoria";
      // 
      // btnAddCategory
      // 
      this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.btnAddCategory.FlatAppearance.BorderSize = 0;
      this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddCategory.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.Plus;
      this.btnAddCategory.IconColor = System.Drawing.Color.White;
      this.btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btnAddCategory.IconSize = 40;
      this.btnAddCategory.Location = new System.Drawing.Point(798, 230);
      this.btnAddCategory.Name = "btnAddCategory";
      this.btnAddCategory.Size = new System.Drawing.Size(250, 40);
      this.btnAddCategory.TabIndex = 2;
      this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnAddCategory.UseVisualStyleBackColor = false;
      this.btnAddCategory.Click += new System.EventHandler(this.inAddCategory_Click);
      // 
      // dgvCategorias
      // 
      this.dgvCategorias.AllowUserToAddRows = false;
      this.dgvCategorias.AllowUserToDeleteRows = false;
      this.dgvCategorias.AllowUserToResizeColumns = false;
      this.dgvCategorias.AllowUserToResizeRows = false;
      this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
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
      this.dgvCategorias.Location = new System.Drawing.Point(121, 251);
      this.dgvCategorias.Name = "dgvCategorias";
      this.dgvCategorias.RowTemplate.Height = 25;
      this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvCategorias.Size = new System.Drawing.Size(430, 259);
      this.dgvCategorias.TabIndex = 3;
      this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // inSearchCategory
      // 
      this.inSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.inSearchCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.inSearchCategory.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
      this.inSearchCategory.BorderSize = 2;
      this.inSearchCategory.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.inSearchCategory.ForeColor = System.Drawing.Color.White;
      this.inSearchCategory.Location = new System.Drawing.Point(121, 183);
      this.inSearchCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inSearchCategory.Multiline = false;
      this.inSearchCategory.Name = "inSearchCategory";
      this.inSearchCategory.Padding = new System.Windows.Forms.Padding(7);
      this.inSearchCategory.PasswordChar = false;
      this.inSearchCategory.Size = new System.Drawing.Size(377, 40);
      this.inSearchCategory.TabIndex = 3;
      this.inSearchCategory.Texts = "";
      this.inSearchCategory.UnderlinedStyle = false;
      this.inSearchCategory._TextChanged += new System.EventHandler(this.inSearchCategory__TextChanged);
      // 
      // btnSearchCategory
      // 
      this.btnSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.btnSearchCategory.Enabled = false;
      this.btnSearchCategory.FlatAppearance.BorderSize = 0;
      this.btnSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSearchCategory.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.btnSearchCategory.IconChar = FontAwesome.Sharp.IconChar.Search;
      this.btnSearchCategory.IconColor = System.Drawing.Color.White;
      this.btnSearchCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btnSearchCategory.IconSize = 40;
      this.btnSearchCategory.Location = new System.Drawing.Point(504, 183);
      this.btnSearchCategory.Name = "btnSearchCategory";
      this.btnSearchCategory.Size = new System.Drawing.Size(47, 40);
      this.btnSearchCategory.TabIndex = 4;
      this.btnSearchCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSearchCategory.UseVisualStyleBackColor = false;
      this.btnSearchCategory.Click += new System.EventHandler(this.inAddCategory_Click);
      // 
      // btnEditCategory
      // 
      this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
      this.btnEditCategory.FlatAppearance.BorderSize = 0;
      this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditCategory.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.btnEditCategory.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
      this.btnEditCategory.IconColor = System.Drawing.Color.White;
      this.btnEditCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btnEditCategory.IconSize = 40;
      this.btnEditCategory.Location = new System.Drawing.Point(798, 324);
      this.btnEditCategory.Name = "btnEditCategory";
      this.btnEditCategory.Size = new System.Drawing.Size(250, 40);
      this.btnEditCategory.TabIndex = 2;
      this.btnEditCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnEditCategory.UseVisualStyleBackColor = false;
      this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
      // 
      // iconButton1
      // 
      this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(102)))), ((int)(((byte)(64)))));
      this.iconButton1.FlatAppearance.BorderSize = 0;
      this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.iconButton1.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
      this.iconButton1.IconColor = System.Drawing.Color.White;
      this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.iconButton1.IconSize = 40;
      this.iconButton1.Location = new System.Drawing.Point(798, 370);
      this.iconButton1.Name = "iconButton1";
      this.iconButton1.Size = new System.Drawing.Size(250, 40);
      this.iconButton1.TabIndex = 2;
      this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.iconButton1.UseVisualStyleBackColor = false;
      // 
      // inEditCategory
      // 
      this.inEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.inEditCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(204)))));
      this.inEditCategory.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(231)))));
      this.inEditCategory.BorderSize = 2;
      this.inEditCategory.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.inEditCategory.ForeColor = System.Drawing.Color.White;
      this.inEditCategory.Location = new System.Drawing.Point(798, 277);
      this.inEditCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.inEditCategory.Multiline = false;
      this.inEditCategory.Name = "inEditCategory";
      this.inEditCategory.Padding = new System.Windows.Forms.Padding(7);
      this.inEditCategory.PasswordChar = false;
      this.inEditCategory.Size = new System.Drawing.Size(250, 40);
      this.inEditCategory.TabIndex = 1;
      this.inEditCategory.Texts = "";
      this.inEditCategory.UnderlinedStyle = false;
      // 
      // FCategorias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.ClientSize = new System.Drawing.Size(1243, 660);
      this.Controls.Add(this.dgvCategorias);
      this.Controls.Add(this.btnSearchCategory);
      this.Controls.Add(this.iconButton1);
      this.Controls.Add(this.btnEditCategory);
      this.Controls.Add(this.btnAddCategory);
      this.Controls.Add(this.labelNameCategory);
      this.Controls.Add(this.inSearchCategory);
      this.Controls.Add(this.inEditCategory);
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
    private FontAwesome.Sharp.IconButton btnAddCategory;
    private System.Windows.Forms.DataGridView dgvCategorias;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private FontAwesome.Sharp.IconButton btnSearchCategory;
    private customControls.CustomInput inSearchCategory;
    private FontAwesome.Sharp.IconButton btnEditCategory;
    private FontAwesome.Sharp.IconButton iconButton1;
    private customControls.CustomInput inEditCategory;
  }
}