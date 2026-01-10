using System;
using System.Collections.Generic;
using System.Text;
using pbo_kerkom.Enums;
using pbo_kerkom.Interfaces;

namespace pbo_kerkom.Models
{
	public abstract class Karyawan : IKaryawan
	{
		public string Nama { get; set; }

		public Jabatan Jabatan { get; set; }

		public abstract double HitungGaji();
	}
}

