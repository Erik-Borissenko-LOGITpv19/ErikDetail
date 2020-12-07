using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ErikDetail.Stranitsi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class oval : ContentPage
    {
        public oval()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void OvalFigure_Clicked(object sender, EventArgs e)
        {
            Uri ovaluri = new Uri("https://www.webmath.ru/web/prog49_1.php");
            await Browser.OpenAsync(ovaluri);
        }
    }
}