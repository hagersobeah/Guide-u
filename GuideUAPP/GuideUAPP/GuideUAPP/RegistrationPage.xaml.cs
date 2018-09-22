using GuideUAPP.Database;
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
    public partial class RegistrationPage : ContentPage
    {
        Connection conn = new Connection();

        public RegistrationPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("GuideUAPP.Assets.logo.png");
        }

         private async Task ResgisterationBtn_ClickedAsync(object sender, EventArgs e)
         {
             try
             {
                 var GENDER = gender.Items[gender.SelectedIndex];
                 if (PasswordText.Text == ConfirmPasswordText.Text)
                 {
                     var x = conn.db.Insert(new User()
                     {
                         FullName = FullnameText.Text,
                         UserName = UsernameText.Text,
                         Email = EmailText.Text,
                         PhoneNum = PhoneNumberText.Text,
                         Password = PasswordText.Text,
                         DOB = DOBText.Date,
                         Gender = GENDER,
                         Country = CountryText.Text,
                         City = CityText.Text
                     });
                     await Navigation.PushModalAsync(new MainServicePage());
                 }
                 else
                 {
                     await DisplayAlert("Error!!", "Password doesn't match", "OK");
                 }
             }
             catch
             {
                 await DisplayAlert("Error!!", "Please enter all the fields", "OK");
             }

         }
    }
}