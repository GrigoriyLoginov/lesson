using System.Globalization;

namespace Task9_1
{
    public static class Formating
    {
        public static string FormatS(this string[] str, string format="A")
        {

            string result = string.Empty;
            string revenue = decimal.Parse(str[1]).ToString("N",CultureInfo.CreateSpecificCulture("en-US"));
            switch (format)
            {
                case "A":
                    result = string.Format("Customer record: {0}, {1}, {2}", str[0], revenue, str[2]);
                    break;
                case "B":
                    result = string.Format("Customer record: {0}", str[2]);
                    break;
                case "C":
                    result = string.Format("Customer record: {0}, {1}", str[0], revenue);
                    break;
                case "D":
                    result = string.Format("Customer record: {0}", str[0]);
                    break;
                case "E":
                    result = string.Format("Customer record: {0}", revenue);
                    break;
                default:
                    result = string.Format("Customer record: {0}, {1}, {2}", str[0], revenue, str[2]);
                    break;
            }
            return result;
        }
    }
}
