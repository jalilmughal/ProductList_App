using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLista2App
{
    public class Validate
    {
        public void CheckForExit(string userInput)
        {
            while ((userInput.ToLower().Trim() == "q") == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du har skrivit 'q', App'en stänges nu!");
                Console.ResetColor();
                break;
            }


            //index++;
        }
        public void CheckForNullOrSpace(string userInput)
        {
            while (String.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ogiltig input!");
                Console.ResetColor();
            }
        }
    }
}
