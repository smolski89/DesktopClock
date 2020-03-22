using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;

namespace DesktopClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer t = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += this.Clock_load;
            
        }
        private void Clock_load(Object sender, EventArgs e)
        {
            t.Interval = new TimeSpan(0,0,01); //czas odswiezania
            t.Tick += new EventHandler(this.t_Tick);
            t.Start(); // uruchomienie licznika
        }
        private void t_Tick(Object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour; // ustawienie godziny
            int mm = DateTime.Now.Minute;  // ustawienie minut
            int ss = DateTime.Now.Second; // ustawienie sekund
            string Time = "";
            //warunki ustawienie formatu 
            if (hh<10)
            {
                Time += "0" + hh;
            }
            else
            {
                Time += hh;
            }
            Time += ":";
            if (mm<10)
            {
                Time += "0" + mm;
            }
            else
            {
                Time += mm;
            }
            Time += ":";
            if (ss<10)
            {
                Time += "0" + ss;
            }
            else
            {
                Time += ss;
            }
            tekst.Content = Time;

        }
    }
}
