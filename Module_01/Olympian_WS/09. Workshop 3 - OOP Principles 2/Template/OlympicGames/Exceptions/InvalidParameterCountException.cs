using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicGames.Exceptions
{
    class InvalidParameterCountException : Exception
    {
        private const string errorMessage = "Parameters count is not valid!";

        public InvalidParameterCountException()
            : base(errorMessage)
        {

        }
    }
}
