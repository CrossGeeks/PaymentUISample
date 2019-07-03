using System;
using System.Globalization;
using Xamarin.Forms;
namespace CreditCardUISample.Converters
{
    public class CardNumberToImageConverter : BaseCardValidator, IValueConverter
    {
        public ImageSource Visa { get; set; }
        public ImageSource Amex { get; set; }
        public ImageSource MasterCard { get; set; }
        public ImageSource Dinners { get; set; }
        public ImageSource Discover { get; set; }
        public ImageSource JCB { get; set; }
        public ImageSource NotRecognized { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return NotRecognized;

            var number = value.ToString();
            var numberNormalized = number.Replace("-", string.Empty);

            if (visaRegex.IsMatch(numberNormalized)) return Visa;

            if (amexRegex.IsMatch(numberNormalized)) return Amex;

            if (masterRegex.IsMatch(numberNormalized)) return MasterCard;

            if (dinnersRegex.IsMatch(numberNormalized)) return Dinners;

            if (discoverRegex.IsMatch(numberNormalized)) return Discover;

            if (jcbRegex.IsMatch(numberNormalized)) return JCB;

            return NotRecognized;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}