using System.Collections.Generic;

namespace Far.Library.Abstractions.Replacers;

public interface ICharReplacer
{
    IEnumerable<string> ReplaceCharacter(IEnumerable<string> enumerable, char toBeReplaced, char replacementChar);
}