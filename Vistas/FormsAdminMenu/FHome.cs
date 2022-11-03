using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkiaSharp;

//using LiveChartsCore;

namespace Vistas.FormsAdminMenu
{
  public partial class FHome : Form
  {
    public FHome()
    {
      InitializeComponent();
    }

    private void FHome_Load(object sender, EventArgs e)
    {
      chartProdMasVendido.AxisX.Add(new LiveCharts.Wpf.Axis
      {
        Title = "Mes",
        Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
      });
      //chartProdMasVendido.AxisY.Add(new LiveCharts.Wpf.Axis
      //{
      //  Title = "ventas",
      //  LabelFormatter = value => value.ToString("C")
      //});

      chartProdMasVendido.LegendLocation = LiveCharts.LegendLocation.Right;

      // Init data
      chartProdMasVendido.Series.Clear();
      SeriesCollection series = new SeriesCollection();

      double[] nums = new double[] { 10, 20, 30, 40 };

      LineSeries lineasGraficas = new LineSeries();
      lineasGraficas.Title = "";
      lineasGraficas.Values = new ChartValues<double>(nums);
      lineasGraficas.Stroke = System.Windows.Media.Brushes.DeepSkyBlue;
      lineasGraficas.Fill = System.Windows.Media.Brushes.Aquamarine;
      lineasGraficas.Opacity = 0.5;
      lineasGraficas.PointForeground = System.Windows.Media.Brushes.Aquamarine;
      series.Add(lineasGraficas);
      chartProdMasVendido.Series = series;

      chartProdMenosVendido.LegendLocation = LiveCharts.LegendLocation.Right;

      chartProdMenosVendido.AxisX.Add(new LiveCharts.Wpf.Axis
      {
        Title = "Mes",
        Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
      });
      // Init data
      chartProdMenosVendido.Series.Clear();
      SeriesCollection series2 = new SeriesCollection();
      double[] nums2 = new double[] { 40, 30, 20, 10 };

      LineSeries lineasGraficas2 = new LineSeries();
      lineasGraficas2.Title = "";
      lineasGraficas2.Values = new ChartValues<double>(nums2);
      lineasGraficas2.Stroke = System.Windows.Media.Brushes.DarkRed;
      lineasGraficas2.Fill = System.Windows.Media.Brushes.IndianRed;
      lineasGraficas2.Opacity = 0.5;
      lineasGraficas2.PointForeground = System.Windows.Media.Brushes.Aquamarine;
      series2.Add(lineasGraficas2);
      chartProdMenosVendido.Series = series2;

      /// MOSTRAR FECHA Y HORA ACTUAL
      
      FechaHora();
    }

    private void FechaHora()
    {
      timerActualizarFecha.Enabled = true;
      string hora = DateTime.Now.ToString("hh:mm tt");
      string fecha = DateTime.Now.ToLongDateString();
      ibtnFechaHora.Text = $"{fecha}   {hora}";
    }

    private void timerActualizarFecha_Tick(object sender, EventArgs e)
    {
      FechaHora();
    }
  }// fin de clase FHome
}
