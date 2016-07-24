using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_Telephony
{
    class Smartphone : ICall, IBrowse
    {
        List<string> phones;
        List<string> webPages;

        public Smartphone()
        {
            this.phones = new List<string>();
            this.webPages = new List<string>();
        }


        public string Call { get; }


        public string AddCall(string phoneNumber)
        {
            if (!phoneNumber.Any(c=>char.IsLetter(c)))
            {
                this.phones.Add(phoneNumber);
                return $"Calling... {phoneNumber}";
            }

            return "Invalid number!";
        }

        public string Browse(string webPage)
        {
            if (!webPage.Any(c => char.IsDigit(c)))
            {
                this.webPages.Add(webPage);
                return $"Browsing: {webPage}!";
            }
            return "Invalid URL!";
        }
    }
}
