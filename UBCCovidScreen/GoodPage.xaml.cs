using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UBCCovidScreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoodPage : ContentPage
    {
        public GoodPage()
        {
            InitializeComponent();

            greenCheck.Source = ImageSource.FromResource("UBCCovidScreen.Assets.Images.Greencheck.png", assembly);
        }

        private void cont1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

    }
}