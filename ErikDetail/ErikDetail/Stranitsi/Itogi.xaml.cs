using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ErikDetail.Stranitsi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Itogi : ContentPage
    {
        public Itogi()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }
    }
}