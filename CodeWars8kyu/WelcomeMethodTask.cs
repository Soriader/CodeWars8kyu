using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars8kyu
{
    public class WelcomeMethodTask
    {
        public static string Greet(string language)
        {
            Dictionary<string, string> greetings = new Dictionary<string, string>
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };

            if (greetings.ContainsKey(language))
            {
                return greetings[language];
            }
            else
            {
                return greetings["english"];
            }
        }
    }
}
//https://www.codewars.com/kata/577ff15ad648a14b780000e7/train/csharp