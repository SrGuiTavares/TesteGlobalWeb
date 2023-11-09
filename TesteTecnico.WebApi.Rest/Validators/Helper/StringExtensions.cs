using System.Text.RegularExpressions;

namespace TesteTecnico.WebApi.Rest.Validators.Helper
{
    public static class StringExtensions
    {
        public static bool IsValidDocument(this string document)
        {
            var experession = "[0-9]{3}\\.?[0-9]{3}\\.?[0-9]{3}\\.?[0-9]{2}";

            return Regex.Match(document, experession).Success;
        }
    }
}
