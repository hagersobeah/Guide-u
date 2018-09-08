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
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();

            TapGestureRecognizer editProfileTap = new TapGestureRecognizer();
            editProfileTap.Tapped += EditProfileTap_Tapped;

            EditProfile.GestureRecognizers.Add(editProfileTap);
        }
        private async void EditProfileTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}