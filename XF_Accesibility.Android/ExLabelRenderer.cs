using System;
using Android.Content;
using Android.Views.Accessibility;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF_Accesibility.CustomControl;
using XF_Accesibility.Droid;

[assembly: ExportRenderer(typeof(ExLabel), typeof(ExLabelRenderer))]
namespace XF_Accesibility.Droid
{
    public class ExLabelRenderer:LabelRenderer
    {
        public ExLabelRenderer(Context context):base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
                {
                    Control.AccessibilityHeading = true;
                }
                else
                    Control.SetAccessibilityDelegate(new LabelHeadingDelegate());
               
            }
        }
    }

    public class LabelHeadingDelegate : Android.Views.View.AccessibilityDelegate
    {

        public override void OnInitializeAccessibilityNodeInfo(Android.Views.View host, AccessibilityNodeInfo info)
        {
            base.OnInitializeAccessibilityNodeInfo(host, info);
            info.ContentDescription = host.ContentDescription + "Heading";

        }



    }
}
