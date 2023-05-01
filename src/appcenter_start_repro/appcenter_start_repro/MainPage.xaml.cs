using Microsoft.AppCenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appcenter_start_repro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AppCenterIsEnabled.Text =
                AppCenter.IsEnabledAsync().Result
                    ? "Enabled"
                    : "Disabled";
        }
    }
}
