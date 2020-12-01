using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ErikDetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            figure.Source = ImageSource.FromFile("MainImageHome.png");
            mainpage.ItemsSource = GetMenuList();
            var Home = typeof(Stranitsi.Home);
            Detail = new NavigationPage((Page)Activator.CreateInstance(Home));
            IsPresented = false;
        }

        public List<Classnumber1> GetMenuList()
        {
            var list = new List<Classnumber1>();
            //---------------------------------------------------------------------------------------

            list.Add(new Classnumber1()
            {
                Text = "Конус",
                Detail = "Это называется конусом",
                ImagePath = "cone.ico",
                TargetPage = typeof(Stranitsi.Konus)
            });
            //---------------------------------------------------------------------------------------

            list.Add(new Classnumber1()
            {
                Text = "Круг",
                Detail = "Это называется кругом",
                ImagePath = "Circle.ico",
                TargetPage = typeof(Stranitsi.kryg)
            });
            //---------------------------------------------------------------------------------------

            list.Add(new Classnumber1()
            {
                Text = "Квадрат",
                Detail = "Это называется квадрат",
                ImagePath = "Kvadrat.ico",
                TargetPage = typeof(Stranitsi.kvadrat)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Овал",
                Detail = "Это называется овал",
                ImagePath = "Oval.ico",
                TargetPage = typeof(Stranitsi.oval)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Параллепепипед",
                Detail = "Это называется параллелепипедом",
                ImagePath = "parallepipped.ico",
                TargetPage = typeof(Stranitsi.paralepiped)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Прямоугольник",
                Detail = "Это называется прямоугольником",
                ImagePath = "prjamoygolnik.ico",
                TargetPage = typeof(Stranitsi.Pramoygolnik)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Ромб",
                Detail = "Это называется ромбом",
                ImagePath = "romb.ico",
                TargetPage = typeof(Stranitsi.Romb)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Треугольник",
                Detail = "Это называется треугольником",
                ImagePath = "triangle.ico",
                TargetPage = typeof(Stranitsi.treygolnik)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Итоги",
                Detail = "А это уже итоги :)",
                ImagePath = "itogi.ico",
                TargetPage = typeof(Stranitsi.Itogi)
            });
            //---------------------------------------------------------------------------------------
            return list;
        }
        
        private void mainpage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}

