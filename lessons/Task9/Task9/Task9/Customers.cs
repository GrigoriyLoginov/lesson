using System.Globalization;

namespace Task9_1
{
    public class Customers
    {
        public string Name { get; }
        public string ContactPhone { get; }
        public decimal Revenue { get; }

        public Customers(string Name, decimal Revenue, string ContactPhone)
        {
            this.Name = Name;
            this.ContactPhone = ContactPhone;
            this.Revenue = Revenue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        public string Print(string format = "A")
        {
            string result = string.Empty;
            string revenue = Revenue.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
            switch (format)
            {
                case "A":
                    result = string.Format("Customer record: {0}, {1}, {2}", Name, revenue, ContactPhone);
                    break;
                case "B":
                    result = string.Format("Customer record: {0}", ContactPhone);
                    break;
                case "C":
                    result = string.Format("Customer record: {0}, {1}", Name, revenue);
                    break;
                case "D":
                    result = string.Format("Customer record: {0}", Name);
                    break;
                case "E":
                    result = string.Format("Customer record: {0}", revenue);
                    break;
                default:
                    result = string.Format("Customer record: {0}, {1}, {2}", Name, revenue, ContactPhone);
                    break;
            }
            return result;
        }   
    }
}
