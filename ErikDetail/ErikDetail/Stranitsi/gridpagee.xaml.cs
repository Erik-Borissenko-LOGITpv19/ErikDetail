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
    public partial class gridpagee : ContentPage
    {
        public gridpagee()
        {
            InitializeComponent();
            BackgroundColor = Color.DarkCyan;
        }

        private void pod4et_Clicked(object sender, EventArgs e)
        {
            resultlabel.Text = $"Твое имя и фамилия: {firstnumber} {secondnubmer}".ToString();
            pod4et.BackgroundColor = Color.White;
            pod4et.Text = "Опа, поменялся  цвет и текст кнопки";
        }
    }
}
