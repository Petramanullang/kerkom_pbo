using System;
using System.Collections.Generic;
using System.Text;

namespace pbo_kerkom.Exceptions
{
    internal class GajiNegatifException : Exception
    {
        public GajiNegatifException(string message) : base(message) { }
    }
}
