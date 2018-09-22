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
	public partial class TouristProfile : ContentPage
	{
		public TouristProfile ()
		{
			InitializeComponent ();
            ImgControl.Source = ImageSource.FromResource("GuideUAPP.Assets.pp.png");
        }
        private async void ChangePassword_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePasswordPage());

        }

        private async void EditProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditTouristProfilePage());
        }
    }
}