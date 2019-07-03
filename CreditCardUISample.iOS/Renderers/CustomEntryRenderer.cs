using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CreditCardUISample.iOS.Renderers;
using CreditCardUISample.Controls;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Entry), typeof(CustomEntryRenderer), new[] { typeof(CustomVisual) })]

namespace CreditCardUISample.iOS.Renderers
{
    public class CustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement!=null)
            {
               Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}
