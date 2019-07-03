using System.Text.RegularExpressions;

namespace CreditCardUISample.Converters
{
    public class BaseCardValidator
    {
        public static Regex visaRegex = new Regex(@"^4[0-9]{6,}$");
        public static Regex masterRegex = new Regex(@"^5[1-5][0-9]{5,}|222[1-9][0-9]{3,}|22[3-9][0-9]{4,}|2[3-6][0-9]{5,}|27[01][0-9]{4,}|2720[0-9]{3,}$");
        public static Regex dinnersRegex = new Regex(@"^3(?:0[0-5]|[68][0-9])[0-9]{4,}$");
        public static Regex discoverRegex = new Regex(@"^6(?:011|5[0-9]{2})[0-9]{3,}$");
        public static Regex jcbRegex = new Regex(@"^(?:2131|1800|35[0-9]{3})[0-9]{3,}$");
        public static Regex amexRegex = new Regex(@"^3[47][0-9]{5,}$");
    }
}
