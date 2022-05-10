using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var langcode = WpfApp5.Properties.Settings.Default.LangaugeCode;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(langcode);
            base.OnStartup(e);
        }

    }
}
