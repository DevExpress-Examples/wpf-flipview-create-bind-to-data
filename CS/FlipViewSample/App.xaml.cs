﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Xpf.Core;

namespace FlipViewSample {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application 
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ThemeManager.ApplicationThemeName = Theme.Office2013Name;
            base.OnStartup(e);
        }
    }
}
