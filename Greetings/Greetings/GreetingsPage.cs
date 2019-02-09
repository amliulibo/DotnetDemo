using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
	public class GreetingsPage : ContentPage
	{
		public GreetingsPage ()
		{

            Label label = new Label();
            label.Text = "Greetings, liulibo";
            //label.VerticalTextAlignment = TextAlignment.Center;
            //label.HorizontalTextAlignment = TextAlignment.Center;
            this.Content = label;

            this.Padding = new Thickness(0, 50, 0, 0);

            

        }
	}
}