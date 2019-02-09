using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
	public class ReflectedColorsPage : ContentPage
	{
		public ReflectedColorsPage()
		{


            StackLayout stackLayout = new StackLayout();
            //foreach (FieldInfo  field   in typeof(Color).GetRuntimeFields())
            //{
            //    if (field.GetCustomAttribute<ObsoleteAttribute>()!=null)
            //    {
            //        continue;
            //    }
            //    if (field.IsPublic&&field.IsStatic&&field.FieldType==typeof(Color))
            //    {
            //        stackLayout.Children.Add(
            //            CreateColorLabel((Color)field.GetValue(null),field.Name)
            //            );

            //    }
            //}

            foreach (PropertyInfo prop in typeof(Color).GetRuntimeProperties())
            {
                MethodInfo methodInfo = prop.GetMethod;
                if (methodInfo.IsPublic && methodInfo.IsStatic && methodInfo.ReturnType == typeof(Color))
                {
                    stackLayout.Children.Add(CreateColorLabel((Color)prop.GetValue(null), prop.Name));
                }
            }

            this.Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
            this.Content = new ScrollView
            {
                Content = stackLayout
            };
            
            

        }
        Label CreateColorLabel(Color color,string name)
        {
            Color backgroundColor = Color.Default;
            if (color!=Color.Default)
            {
                double luminance = 0.3 * color.R + 0.59 * color.G + 0.11 * color.B;
                backgroundColor = luminance > 0.5 ? Color.Black : Color.White;
            }
            return new Label {
                Text = name,
                TextColor=color,
                FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Label)),
                BackgroundColor=backgroundColor
            };
        }
	}
}