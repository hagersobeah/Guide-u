using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            fbImg.Source = ImageSource.FromResource("GuideUAPP.Assets.fbicon.png");
            googleImg.Source = ImageSource.FromResource("GuideUAPP.Assets.googleicon.png");
            logo.Source = ImageSource.FromResource("GuideUAPP.Assets.applogo.png");

            TapGestureRecognizer loginBtnTap = new TapGestureRecognizer();

            loginBtnTap.Tapped += LoginBtnTap_Tapped;

            loginBtn.GestureRecognizers.Add(loginBtnTap);
        }

        private async void LoginBtnTap_Tapped(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new NavigationPage(new MainServicePage()));
        }
    }
}