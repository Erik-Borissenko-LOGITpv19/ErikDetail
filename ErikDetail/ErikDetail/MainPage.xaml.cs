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
            //---------------------------------------------------------------------------------------
            var list = new List<Classnumber1>();

            list.Add(new Classnumber1()
            {
                Text = "Конус",
                ImagePath = "cone.ico",
                TargetPage = typeof(Stranitsi.Konus)
            });
            //---------------------------------------------------------------------------------------

            list.Add(new Classnumber1()
            {
                Text = "Круг",
                ImagePath = "Circle.ico",
                TargetPage = typeof(Stranitsi.kryg)
            });
            //---------------------------------------------------------------------------------------

            list.Add(new Classnumber1()
            {
                Text = "Квадрат",
                ImagePath = "Kvadrat.ico",
                TargetPage = typeof(Stranitsi.kvadrat)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Овал",
                ImagePath = "Oval.ico",
                TargetPage = typeof(Stranitsi.oval)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Параллепепипед",
                ImagePath = "parallepipped.ico",
                TargetPage = typeof(Stranitsi.paralepiped)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Прямоугольник",
                ImagePath = "prjamoygolnik.ico",
                TargetPage = typeof(Stranitsi.Pramoygolnik)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Ромб",
                ImagePath = "romb.png",
                TargetPage = typeof(Stranitsi.Romb)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Треугольник",
                ImagePath = "triangle.png",
                TargetPage = typeof(Stranitsi.treygolnik)
            });
            //---------------------------------------------------------------------------------------
            list.Add(new Classnumber1()
            {
                Text = "Итоги",
                ImagePath = "star.png",
                TargetPage = typeof(Stranitsi.Itogi)
            });
            //---------------------------------------------------------------------------------------
            return list;
        }
        
        private void mainpage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (Classnumber1)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}

