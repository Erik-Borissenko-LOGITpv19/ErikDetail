﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ErikDetail.Stranitsi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private void imgbtn_Clicked(object sender, EventArgs e)
        {
            lbl1.Text = "Секретик :)";
        }
    }
}