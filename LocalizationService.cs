using System.Collections.Generic;

namespace MovieManager
{
    public class LocalizationService
    {
        private Dictionary<string, Dictionary<string, string>> _translations = new Dictionary<string, Dictionary<string, string>>
        {
            { "en", new Dictionary<string, string>
                {
                    { "add", "Add a new movie:" },
                    { "unsupported_language", "Unsupported language." },
                    { "list_empty", "The movie list is empty." },
                    { "language_changed", "Language changed successfully." },
                    { "unsupported_command", "Unsupported command." },
                    { "movies_loaded", "Movies loaded successfully." },
                    { "movies_saved", "Movies saved successfully." },
                    { "search_results", "Search results:" },
                    { "no_results", "No results found." },
                    { "help", "Available commands: help, add, list, lang, load, save, search, exit." }
                }
            },
            { "fr", new Dictionary<string, string>
                {
                    { "add", "Ajouter un nouveau film:" },
                    { "unsupported_language", "Langue non supportée." },
                    { "list_empty", "La liste des films est vide." },
                    { "language_changed", "Langue changée avec succès." },
                    { "unsupported_command", "Commande non supportée." },
                    { "movies_loaded", "Films chargés avec succès." },
                    { "movies_saved", "Films enregistrés avec succès." },
                    { "search_results", "Résultats de la recherche:" },
                    { "no_results", "Aucun résultat trouvé." },
                    { "help", "Commandes disponibles : help, add, list, lang, load, save, search, exit." }
                }
            }
        };

        private string _currentLanguage = "en";

        public bool SetLanguage(string language)
        {
            if (_translations.ContainsKey(language))
            {
                _currentLanguage = language;
                return true;
            }
            return false;
        }

        public string Translate(string key)
        {
            if (_translations[_currentLanguage].TryGetValue(key, out var translation))
            {
                return translation;
            }
            return "Translation not found.";
        }
    }
}
