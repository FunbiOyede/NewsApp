using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewsApp.Controls
{
   public class SquareImages : ContentView
    {

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            HeightRequest = Width;
        }
    }
}
