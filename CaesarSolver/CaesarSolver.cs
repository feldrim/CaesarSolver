using System.Linq;

namespace CaesarSolver
{
   public class CaesarSolver
   {
      private readonly string _charset;
      private readonly char[] _ignoredChars;

      public CaesarSolver(string charset) : this(charset, string.Empty)
      {
      }

      public CaesarSolver(string charset, string ignoredChars) : this(charset, ignoredChars.ToCharArray())
      {
      }

      public CaesarSolver(string charset, char[] ignoredChars)
      {
         _charset = charset;
         _ignoredChars = ignoredChars;
      }

      public string Solve(string encryptedText)
      {
         var textArr = encryptedText.ToCharArray();

         for (var i = 0; i < textArr.Length; i++)
         {
            if (_ignoredChars.Contains(textArr[i])) continue;
            var currentIndex = _charset.IndexOf(textArr[i]);
            if (_ignoredChars.Contains(textArr[i])) continue;
            var newIndex = currentIndex - i;
            while (newIndex < 0 || newIndex >= _charset.Length) newIndex = _charset.Length + newIndex;
            var newChar = _charset[newIndex];
            textArr[i] = newChar;
         }

         return new string(textArr);
      }
   }
}