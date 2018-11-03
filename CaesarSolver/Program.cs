using System;

namespace CaesarSolver
{
   internal class Program
   {
      public static void Main()
      {
         const string encryptedText = "Ypw ewk onDEuAu rvLMyM VCS ZQX FXL 13TXY X3 b0Y eXb21fp. db wnu vkmsq GxE mEs HvswS BLP TIG TFX06, SQ4S Y9 h8fd 3a07 XpVXa5g3qt4h8";
         const string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
         const string ignoredChars = " .,";

         var cs = new CaesarSolver(charset, ignoredChars);
         var res = cs.Solve(encryptedText);

         Console.WriteLine(res);
         Console.ReadLine();
      }
   }
}