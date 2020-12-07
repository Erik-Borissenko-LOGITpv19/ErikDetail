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
    public partial class treygolnik : ContentPage
    {
        public treygolnik()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private async void Triangle_Clicked(object sender, EventArgs e)
        {
            Uri triangleuri = new Uri("https://ru.onlinemschool.com/math/formula/rectangle/");
            await Browser.OpenAsync(triangleuri);
        }
    }
}