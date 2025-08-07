using System.Collections.Generic;
​
public static class Kata
    {
        public static string Greet(string language)
        {
          var dict = new Dictionary<string, string>()
          {
            {"english", "Welcome"}, {"czech", "Vitejte"}, {"danish", "Velkomst"}, {"dutch", "Welkom"}, {"estonian", "Tere tulemast"}, {"finnish", "Tervetuloa"}, {"flemish", "Welgekomen"}, {"french", "Bienvenue"}, {"german", "Willkommen"}, {"irish", "Failte"}, {"italian", "Benvenuto"}, {"latvian", "Gaidits"}, {"lithuanian", "Laukiamas"}, {"polish", "Witamy"}, {"spanish", "Bienvenido"}, {"swedish", "Valkommen"}, {"welsh", "Croeso"}
          };
          if (dict.ContainsKey(language)) return dict[language];
          return "Welcome";
        }
    }