using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TouristicPlacePage : ContentPage
    {
        public TouristicPlacePage()
        {
            InitializeComponent();
            TapGestureRecognizer videoTap = new TapGestureRecognizer();
           
            TapGestureRecognizer backTap = new TapGestureRecognizer();




            videoTap.Tapped += VideoTap_Tapped;
          
            backTap.Tapped += BackTap_Tapped;

            video.GestureRecognizers.Add(videoTap);
        
            back.GestureRecognizers.Add(backTap);

        }

        private void BackTap_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void ClosePopoUpTap_Tapped(object sender, EventArgs e)
        {
             if(videoPopup.IsVisible==true)
            videoPopup.IsVisible = false;


        }

        private void VideoTap_Tapped(object sender, EventArgs e)
        {
            if (videoPopup.IsVisible == false)
                videoPopup.IsVisible = true;
           


        }

    }
}