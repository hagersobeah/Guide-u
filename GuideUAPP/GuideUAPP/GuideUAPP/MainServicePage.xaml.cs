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
    public partial class MainServicePage : MasterDetailPage
    {
        public MainServicePage()
        {
            InitializeComponent();
            TapGestureRecognizer profileTap = new TapGestureRecognizer();
            TapGestureRecognizer aboutUsTap = new TapGestureRecognizer();
            TapGestureRecognizer logoutTap = new TapGestureRecognizer();
            TapGestureRecognizer settingsTap = new TapGestureRecognizer();
            TapGestureRecognizer paymentTap = new TapGestureRecognizer();
            TapGestureRecognizer tourGuideTap = new TapGestureRecognizer();

            TapGestureRecognizer menuTap = new TapGestureRecognizer();


            profileTap.Tapped += ProfileTap_Tapped;
            aboutUsTap.Tapped += AboutUsTap_Tapped;
            logoutTap.Tapped += LogoutTap_Tapped;
            paymentTap.Tapped += PaymentTap_Tapped;
            tourGuideTap.Tapped += TourGuideTap_Tapped;
            settingsTap.Tapped += SettingsTap_Tapped;
            menuTap.Tapped += MenuTap_Tapped;






            profileGrid.GestureRecognizers.Add(profileTap);
            aboutUs.GestureRecognizers.Add(aboutUsTap);
            logout.GestureRecognizers.Add(logoutTap);
            settings.GestureRecognizers.Add(settingsTap);
            tourGuide.GestureRecognizers.Add(tourGuideTap);
            payment.GestureRecognizers.Add(paymentTap);
            hamburgerMenu.GestureRecognizers.Add(menuTap);

            
        }

        private void MenuTap_Tapped(object sender, EventArgs e)
        {
            var mainPage = (Application.Current.MainPage as NavigationPage).CurrentPage;
            (mainPage as MasterDetailPage).IsPresented = true;
        }



        private async void SettingsTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TouristicPlacePage());
        }

        private async void TourGuideTap_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new TGHistory());

        }

        private async void PaymentTap_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PaymentMethodPage());
        }

        private async void LogoutTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SigninPage());
        }

        private async void AboutUsTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }

        private async void ProfileTap_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TouristProfile());
        }


    }
}