﻿
namespace Vistas.FormsAdminMenu
{
  partial class FProveedores
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
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Poppins", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.label1.Location = new System.Drawing.Point(253, 225);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(245, 62);
      this.label1.TabIndex = 0;
      this.label1.Text = "Proveedores";
      // 
      // FProveedores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
      this.ClientSize = new System.Drawing.Size(799, 660);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "FProveedores";
      this.Text = "FProveedores";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
  }
}