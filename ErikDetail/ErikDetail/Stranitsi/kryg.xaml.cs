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
    public partial class kryg : ContentPage
    {
        public kryg()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void Circlefigure_Clicked(object sender, EventArgs e)
        {
            Uri kryguri = new Uri("https://www.webmath.ru/poleznoe/formules9.php");
            await Browser.OpenAsync(kryguri);
        }
    }
}