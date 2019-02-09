using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
	public class BaskervillesPage : ContentPage
	{
		public BaskervillesPage()
		{

            this.Content = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                Text = "sssssssssssssssssssssssssssssssssss]n" +
            "222222222222222222222222222222222222222222222222\n" +
            "32222222222222222222222222222222222222222222222223\n" +
            "42222222222222222222222222222222222222222222222224\n",
                BackgroundColor = Color.Yellow,
                TextColor=Color.Blue
            

            };
            //Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
            

        }
	}
}