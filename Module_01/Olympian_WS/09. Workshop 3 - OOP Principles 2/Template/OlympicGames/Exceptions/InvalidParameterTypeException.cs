using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicGames.Exceptions
{
    class InvalidParameterTypeException : Exception
    {
        private const string errorMessage = "{0} must be {1}!";

        public InvalidParameterTypeException(string param, string type)
            : base(string.Format(errorMessage, param, type))
        {

        }
    }
}
