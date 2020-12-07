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
    public partial class Romb : ContentPage
    {
        public Romb()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void Rombbtn_Clicked(object sender, EventArgs e)
        {
            Uri romburi = new Uri("https://www.webmath.ru/poleznoe/formules15.php");
            await Browser.OpenAsync(romburi);
        }
    }
}