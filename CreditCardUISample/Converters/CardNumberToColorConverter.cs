using System;
using System.Globalization;
using Xamarin.Forms;

namespace CreditCardUISample.Converters
{
    public class CardNumberToColorConverter : BaseCardValidator, IValueConverter
    {
        public Color Visa { get; set; }
        public Color Amex { get; set; }
        public Color MasterCard { get; set; }
        public Color Dinners { get; set; }
        public Color Discover { get; set; }
        public Color JCB { get; set; }
        public Color NotRecognized { get; set; }

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
