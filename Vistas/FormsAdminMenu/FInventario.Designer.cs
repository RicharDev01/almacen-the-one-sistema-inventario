﻿
namespace Vistas.FormsAdminMenu
{
  partial class FInventario
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
      this.label1.Location = new System.Drawing.Point(295, 215);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(203, 62);
      this.label1.TabIndex = 0;
      this.label1.Text = "Inventario";
      // 
      // FInventario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 681);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.Name = "FInventario";
      this.Text = "FInventario";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
  }
}