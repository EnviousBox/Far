using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Far.Library;

public class CharReplacer
{

    /// <summary>
    /// Replaces a specified character in an IEnumerable of strings with a specified replacement character.
    /// </summary>
    /// <param name="enumerable">The IEnumerable of strings to be searched.</param>
    /// <param name="toBeReplaced">The char to be replaced.</param>
    /// <param name="replacementChar">The char to be used as the replacement.</param>
    /// <returns>The modified IEnumerable of strings if the char to be replaced was found; The unmodified original IEnumerable otherwise.</returns>
    public IEnumerable<string> ReplaceCharacter(IEnumerable<string> enumerable, char toBeReplaced, char replacementChar)
    {
        List<string> output = new();
        output.TrimExcess();
        
        string[] strings = enumerable.ToArray();

        foreach (string s in strings)
        {
            string tempStr = s;

            if (s.Contains(toBeReplaced))
            {
                tempStr = tempStr.Replace(toBeReplaced, replacementChar);
            }
            
            output.Add(tempStr);
        }

        return output;
    }
}