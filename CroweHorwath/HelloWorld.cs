using System;

namespace CroweHorwath
{
    /// <summary>
    /// Represent the standard application greeting for Crowe Horwath
    /// </summary>
    public class HelloWorld
    {
        //Field
        private string _message = string.Empty;
        public HelloWorld() : base()
        {
            _message = Messages.Greeting;
        }
        public string SayGreeting()
        {
            return _message;
        }
    
    }
}
