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
using System.Globalization;
using Controlador;

//using LiveChartsCore;

namespace Vistas.FormsAdminMenu
{
  public partial class FHome : Form
  {
    MainScreenController msc = new MainScreenController();

    public FHome()
    {
      InitializeComponent();
    }

    private void FHome_Load(object sender, EventArgs e)
    {
      // MOSTRAR LAS GRAFICAS
      ShowGraficas();

      /// MOSTRAR FECHA Y HORA ACTUAL
      
      FechaHora();

      // obtener el producto mas vendido
      labelCountProduct.Text = msc.getProductoMasVendido()[1];
      labelNameProduct.Text = msc.getProductoMasVendido()[2];

      // obtener el producto menos vendido
      labelCountMenosVendido.Text = msc.getProductoMenosVendido()[1];
      labelNameMenosVendido.Text = msc.getProductoMenosVendido()[2];

    }// FIN DE METODO LOAD

    // metodo de mostrar garfocas de mas vendido y menos vendido
    public void ShowGraficas()
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
    }

    // funcion que realiza imprime la fecha y hora actuaal.
    private void FechaHora()
    {
      timerActualizarFecha.Enabled = true;
      string hora = DateTime.Now.ToString("hh:mm tt");
      string fecha = DateTime.Now.ToLongDateString();
      string dia = DateTime.Now.Date.ToString("dddd", new CultureInfo("es-ES"));
      ibtnFechaHora.Text = $"{fecha}   {hora}";
      labelWelcome.Text = $"Estas son las novedadades del día {dia}";
    }

    private void timerActualizarFecha_Tick(object sender, EventArgs e)
    {
      FechaHora();
    }


  }// fin de clase FHome
}
