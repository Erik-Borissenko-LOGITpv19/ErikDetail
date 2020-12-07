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
    public partial class kvadrat : ContentPage
    {
        public kvadrat()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void CubeFigure_Clicked(object sender, EventArgs e)
        {
            Uri cubeuri = new Uri("https://www.webmath.ru/poleznoe/formules12.php");
            await Browser.OpenAsync(cubeuri);
        }
    }
}