using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideUAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TourGuidePage : ContentPage
	{
        public ObservableCollection<TourGuideViewModel> TourGuides { get; set; }

        public TourGuidePage ()
		{
			InitializeComponent ();
            TourGuides = new ObservableCollection<TourGuideViewModel>();
            TourGuides.Add(new TourGuideViewModel { Name = "Ahmed Samy", Image = "GuideUV1.Assets.tg.png", Rating = "Assets/rating.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Monica Saeed", Image = "tg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Salma El-Sawi", Image = "tg.png" });
            listView.ItemsSource = TourGuides;
        }
	}
}