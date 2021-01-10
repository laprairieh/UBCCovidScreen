using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UBCCovidScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            bool isFNEmpty = string.IsNullOrEmpty(fName.Text);
            bool isLNEmpty = string.IsNullOrEmpty(lName.Text);
            bool isSportEmpty = string.IsNullOrEmpty(SportPicker.Text);
            if(isFNEmpty|| isLNEmpty || isSportEmpty)
            {
                DisplayAlert("Error", "Please fill out all fields", "OK");
            }
            else
            {
                Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
