using System.ComponentModel;
using CreditCardUISample.ViewModels;
using Xamarin.Forms;

namespace CreditCardUISample.Views
{
    [DesignTimeVisible(false)]
    public partial class CreditCardPage : ContentPage
    {
        public CreditCardPage()
        {
            InitializeComponent();
            this.BindingContext = new CreditCardPageViewModel();
        }
    }
}
