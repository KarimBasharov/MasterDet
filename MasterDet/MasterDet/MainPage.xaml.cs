using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDet
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("jojo.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Джонатан Джостар",
                Detail = "первый из ДжоДжо",
                ImagePath = "Jona.jpeg",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Джозеф Джостар",
                Detail = "второй из ДжоДжо",
                ImagePath = "Jose.jpg",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Куджо Джотаро",
                Detail = "третий из ДжоДжо",
                ImagePath = "Jota.webp",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Хигашиката Джоске",
                Detail = "четвертый из ДжоДжо",
                ImagePath = "Josk.jpg",
                TargetPage = typeof(Views.AchievemnetPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Джорно Джованна",
                Detail = "пятый из ДжоДжо",
                ImagePath = "gio.jpg",
                TargetPage = typeof(Views.Cat1)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Спидвагон",
                Detail = "Друг Джонатана",
                ImagePath = "speed.jpg",
                TargetPage = typeof(Views.Speed)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Жан-Пьер Польнарефф",
                Detail = "Друг Джотаро",
                ImagePath = "pol.jpg",
                TargetPage = typeof(Views.Polnareff)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Нориаки Какёин",
                Detail = "Друг Джотаро",
                ImagePath = "kakein.jpg",
                TargetPage = typeof(Views.Kakein)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Дио Брандо",
                Detail = "Враг ДжоДжо",
                ImagePath = "dio.jpg",
                TargetPage = typeof(Views.Dio)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Кира Йошикаге",
                Detail = "Враг ДжоДжо",
                ImagePath = "kira.jpg",
                TargetPage = typeof(Views.Kira)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
