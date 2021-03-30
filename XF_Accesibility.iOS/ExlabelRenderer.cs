using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF_Accesibility.CustomControl;
using XF_Accesibility.iOS;

[assembly: ExportRenderer(typeof(ExLabel), typeof(ExlabelRenderer))]
namespace XF_Accesibility.iOS
{
    public class ExlabelRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.AccessibilityTraits = UIKit.UIAccessibilityTrait.Header;
            }
           
        }
    }
}
