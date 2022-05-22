using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SE4FormApplication
{
   public class InputHandler
    {
       public void seperateNumbersAndLetters(String userInput)
        {
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result = re.Match(userInput);

            string alphaPart = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;
        }
    }
}
