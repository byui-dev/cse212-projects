public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        _words[fromWord] = toWord;
        // If the word already exists, it will be replaced with the new translation
        // If you want to prevent overwriting, you can check if it exists first:    
        // if (!_words.ContainsKey(fromWord))
        // {
        //     _words[fromWord] = toWord;
        // }
        Console.WriteLine($"Added translation: {fromWord} -> {toWord}");
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        if (_words.TryGetValue(fromWord, out var toWord))
        {
            return toWord;
        }
        else
        {
            Console.WriteLine($"No translation found for: {fromWord}");
            return "???"; // Return "???" if no translation is available
        }
        return "";
    }
}