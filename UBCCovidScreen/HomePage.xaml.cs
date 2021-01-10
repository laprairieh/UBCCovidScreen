using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UBCCovidScreen
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }

        private void submit_Clicked(object sender, EventArgs e)
        {
            if (Y1.isClicked && Y2.isClicked && Y3.isClicked)
            {
                Navigation.PushAsync(new BadPage());
            }
            else
            {
                Navigation.PushAsync(new GoodPage());
            }
        }
    }
}
