using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Greetings
{
    class FramedTextPage : ContentPage
    {
       public FramedTextPage()
        {
            BackgroundColor = Color.Aqua;
            Padding = new Thickness(20);
            Content = new Frame
            {
                OutlineColor = Color.Black,
                BackgroundColor=Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Label
                {
                    Text = "I've been framed",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    TextColor=Color.Blue,
                    BackgroundColor=Color.Orange
                    
                }
            };
        }

    }
}
