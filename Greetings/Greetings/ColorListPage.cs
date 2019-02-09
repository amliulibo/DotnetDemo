using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
	public class ColorListPage : ContentPage
	{
		public ColorListPage()
		{
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);

            double fontsize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="white",
                        TextColor= Color.White,
                        FontSize=fontsize
                    },
                    new Label
                    {
                        Text="silver",
                        TextColor= Color.Silver,
                        FontSize=fontsize
                    },
                    new Label
                    {
                        Text="Fuchsia",
                        TextColor= Color.Fuchsia,
                        FontSize=fontsize
                    },
                    new Label
                    {
                        Text="Purple",
                        TextColor= Color.Purple,
                        FontSize=fontsize
                    }

                }
            };
            

        }
	}
}