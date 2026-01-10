using pbo_kerkom.Abstracts;
using pbo_kerkom.Enums;

namespace pbo_kerkom.Models
{
	public class Staf : KaryawanBase
	{
		public Staf(int id, string nama)
			: base(id, nama, Jabatan.Staf)
		{
		}

		public override double HitungGaji()
		{
			// gaji contoh
			return 3000000;
		}
	}
}
