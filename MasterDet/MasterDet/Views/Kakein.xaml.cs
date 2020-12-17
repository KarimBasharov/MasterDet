using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kakein : ContentPage
    {
        public Kakein()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://jojo.fandom.com/ru/wiki/Нориаки_Какёин");
            await Browser.OpenAsync(uri);
        }
    }
}