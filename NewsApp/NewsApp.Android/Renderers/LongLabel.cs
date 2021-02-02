using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NewsApp.Droid.Renderers;
using NewsApp.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LongLabelRenderer), typeof(LongLabel))]
namespace NewsApp.Droid.Renderers
{
   
    public class LongLabel : LabelRenderer
    {

        public LongLabel(Context context) : base(context)
        {
                
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetMaxLines(100000);
            }
        }

    }
}