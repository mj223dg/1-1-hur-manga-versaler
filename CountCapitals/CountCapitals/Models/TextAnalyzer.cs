using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace CountCapitals.Models
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            var CountCapitals = 0;

            for (var i = 0; i < text.Length; ++i)
            {
                if(Char.IsUpper(text[i]))
                {
                    CountCapitals += 1;
                }
            }
            return CountCapitals;
        }
    }
}