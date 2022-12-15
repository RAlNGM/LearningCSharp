using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Logger
    {
        public void Evented(string message)
        {
            Button button = new Button();
            button.CustomHandler += (s, args) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
            };
            button.OnCustomEvent();
        }

        protected class Button
        {
            public EventHandler CustomHandler;
            public void OnCustomEvent()
            {
                CustomHandler.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
