using System;
using System.Collections.Generic;
using System.Text;
using pbo_kerkom.Abstracts;
using pbo_kerkom.Enums;

namespace pbo_kerkom.Models
{
	public class Supervisor : KaryawanBase
	{
		public Supervisor(int id, string nama)
			: base(id, nama, Jabatan.Supervisor)
		{
		}

		public override double HitungGaji()
		{
			return 5000000;
		}
	}
}

