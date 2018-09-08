using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace GuideUAPP
{
    public class TourGuideViewCode : ContentPage
    {

        public ObservableCollection<TourGuideViewModel> TourGuides { get; set; }

        public TourGuideViewCode()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            TourGuides = new ObservableCollection<TourGuideViewModel>();
            ListView lstView = new ListView();
            lstView.RowHeight = 80;
            lstView.ItemTemplate = new DataTemplate(typeof(CustomTourGuideCell));
            TourGuides.Add(new TourGuideViewModel { Name = "Ahmed Samy", Image = "Assets/tg.PNG", Rating = "Assets/rating.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Monica Saeed", Image = "Assets/tgg.png", Rating = "Assets/rating.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Salma El-Sawi", Image = "Assets/tggg.png", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Ahmed Samy", Image = "Assets/tg.PNG", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Monica Saeed", Image = "Assets/tgg.png", Rating = "Assets/ratingg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Salma El-Sawi", Image = "Assets/tggg.png", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Ahmed Samy", Image = "Assets/tg.PNG", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Monica Saeed", Image = "Assets/tgg.png", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Salma El-Sawi", Image = "Assets/tggg.png", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Ahmed Samy", Image = "Assets/tg.PNG", Rating = "Assets/ratinggg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Monica Saeed", Image = "Assets/tgg.png", Rating = "Assets/ratingggg.png" });
            TourGuides.Add(new TourGuideViewModel { Name = "Salma El-Sawi", Image = "Assets/tggg.png", Rating = "Assets/ratingggg.png" });
            lstView.ItemsSource = TourGuides;
            Content = lstView;
        }

        public class CustomTourGuideCell : ViewCell
        {

            public CustomTourGuideCell()
            {
                //instantiate each of our views
                var image = new Image();
                var nameLabel = new Label();
                var rating = new Image();
                var verticaLayout = new StackLayout();
                var horizontalLayout = new StackLayout() { BackgroundColor = Color.White };


                //set bindings
                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));
                rating.SetBinding(Image.SourceProperty, new Binding("Rating"));



                //Set properties for desired design
                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                verticaLayout.VerticalOptions = LayoutOptions.Fill;
                image.HorizontalOptions = LayoutOptions.Start;
                rating.WidthRequest = 100;
                rating.HeightRequest = 40;
                rating.HorizontalOptions = LayoutOptions.Start;
                nameLabel.FontSize = 24;
                nameLabel.VerticalOptions = LayoutOptions.Center;
                nameLabel.HorizontalOptions = LayoutOptions.Center;



                //add views to the view hierarchy
                verticaLayout.Children.Add(nameLabel);
                verticaLayout.Children.Add(rating);
                horizontalLayout.Children.Add(image);
                horizontalLayout.Children.Add(verticaLayout);



                // add to parent view
                View = horizontalLayout;



            }
        }
    }
}
