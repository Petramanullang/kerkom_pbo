using System;
using System.Collections.Generic;
using System.Text;

namespace pbo_kerkom.Exceptions
{
	public class GajiNegatifException : Exception
	{
		public GajiNegatifException()
			: base("Gaji tidak boleh bernilai negatif.")
		{
		}
	}
}
