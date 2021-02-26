using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace t.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Item4 : ContentPage
    {
        public Item4()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("");
            await Browser.OpenAsync(uri);
        }
    }
}