using System;
using System.Collections.Generic;
using System.Text;
using pbo_kerkom.Enums;

namespace pbo_kerkom.Interfaces
{
	public interface IKaryawan
	{
		string Nama { get; set; }
		Jabatan Jabatan { get; set; }

		double HitungGaji();
	}
}

