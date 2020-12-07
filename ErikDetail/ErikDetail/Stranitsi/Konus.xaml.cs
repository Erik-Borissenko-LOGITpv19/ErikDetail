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
    public partial class Konus : ContentPage
    {
        public Konus()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void ConeFurmula_Clicked(object sender, EventArgs e)
        {
            Uri coneuri = new Uri("https://infofaq.ru/obem-konusa.html");
            await Browser.OpenAsync(coneuri);
        }
    }
}