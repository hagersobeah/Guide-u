﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace GuideUAPP.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("IN0qUyB7Rh4Csvn3w8tl~queuXmScEwYnmKS4tFJKzQ~Ar2LAePuHFWeGi-lVU0Yqvc_Ry0q_1T12twN9_rT_FOmm28BsuXlqpX-eajdWgUH");

            LoadApplication(new GuideUAPP.App());
        }
    }
}
