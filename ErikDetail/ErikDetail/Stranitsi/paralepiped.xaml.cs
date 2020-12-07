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
    public partial class paralepiped : ContentPage
    {
        public paralepiped()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void paral_Clicked(object sender, EventArgs e)
        {
            Uri paraluri = new Uri("https://shkolkovo.net/theory/155");
            await Browser.OpenAsync(paraluri);
        }
    }
}