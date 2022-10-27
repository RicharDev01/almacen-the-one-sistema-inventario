using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vistas.customControls
{
  public partial class CustomInput : UserControl
  {

    //Fields
    private Color borderColor = Color.FromArgb(87, 86, 204);
    private int borderSize = 2;
    private bool underlinedStyle = false;
    private Color borderFocusColor = Color.FromArgb(223, 126, 231);
    private bool isFocused = false;

    public CustomInput()
    {
      InitializeComponent();
    }

    public event EventHandler _TextChanged;

    //Properties
    [Category("Input properties")]
    public Color BorderColor
    {
      get { return borderColor; }
      set
      {
        borderColor = value;
        this.Invalidate();
      }
    }

    //=============================================
    [Category("Custom properties")]
    public int BorderSize
    {
      get { return borderSize; }
      set
      {
        borderSize = value;
        this.Invalidate();
      }
    }

    //=============================================
    [Category("Custom properties")]
    public bool UnderlinedStyle
    {
      get { return underlinedStyle; }
      set
      {
        underlinedStyle = value;
        this.Invalidate();
      }
    }

    //=============================================
    [Category("Custom properties")]
    public bool PasswordChar
    {
      get { return textBox1.UseSystemPasswordChar; }
      set { textBox1.UseSystemPasswordChar = value; }
    }

    //=============================================
    [Category("Custom properties")]
    public bool Multiline
    {
      get { return textBox1.Multiline; }
      set { textBox1.Multiline = value; }
    }

    //=============================================
    [Category("Custom properties")]
    public override Color BackColor
    {
      get { return base.BackColor; }
      set
      {
        base.BackColor = value;
        textBox1.BackColor = value;
      }
    }

    //=============================================
    [Category("Custom properties")]
    public override Color ForeColor
    {
      get { return base.ForeColor; }
      set
      {
        base.ForeColor = value;
        textBox1.ForeColor = value;
      }
    }

    //=============================================
    [Category("Custom properties")]
    public override Font Font
    {
      get { return base.Font; }
      set
      {
        base.Font = value;
        textBox1.Font = value;
        if (this.DesignMode)
          UpdateControlHeight();
      }
    }

    //=============================================
    [Category("Custom properties")]
    public string Texts
    {
      get { return textBox1.Text; }
      set { textBox1.Text = value; }
    }

    //=============================================
    [Category("Custom properties")]
    public Color BorderFocusColor
    {
      get { return borderFocusColor; }
      set { borderFocusColor = value; }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Graphics graph = e.Graphics;

      //Draw border
      using (Pen penBorder = new Pen(borderColor, borderSize))
      {
        penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
        if (isFocused) penBorder.Color = borderFocusColor;

        if (underlinedStyle) //Line Style
          graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
        else //Normal Style
          graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
      }
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      if (this.DesignMode)
        UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateControlHeight();
    }

    //Private methods
    private void UpdateControlHeight()
    {
      if (textBox1.Multiline == false)
      {
        int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
        textBox1.Multiline = true;
        textBox1.MinimumSize = new Size(0, txtHeight);
        textBox1.Multiline = false;

        this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
      }
    }

    //===========================================
    // TextBox events (más comunes)
    //===========================================

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (_TextChanged != null)
        _TextChanged.Invoke(sender, e);
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
      isFocused = true;
      this.Invalidate();
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      isFocused = false;
      this.Invalidate();
    }
  }// fin de clase 
}// fin de namespace
