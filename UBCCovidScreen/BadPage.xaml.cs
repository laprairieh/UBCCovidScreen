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
    public partial class BadPage : ContentPage
    {
        public BadPage()
        {
            InitializeComponent();

            redX.Source = ImageSource.FromResource("UBCCovidScreen.Assets.Images.RedX.png", assembly);
        }

        private void cont2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}