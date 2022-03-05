
namespace TextProcessingApp
{
    internal static class Global
    {
        internal static Dictionary<string, List<Position>> WordDictionary =
            new Dictionary<string, List<Position>>();
        internal static string SearchError = "Error: No such word";
        internal static string[] CharsToRemove = { ".", ",", ";", ":", "\'", "\"" };
        internal static string FileFilters = "Text files (*.txt)|*.txt|" + "All files (*.*)|*.*";
    }
}
