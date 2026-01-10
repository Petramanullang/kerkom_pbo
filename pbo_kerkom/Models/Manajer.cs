using pbo_kerkom.Abstracts;
using pbo_kerkom.Enums;

namespace pbo_kerkom.Models
{
	public class Manajer : KaryawanBase
	{
		public Manajer(int id, string nama)
			: base(id, nama, Jabatan.Manajer)
		{
		}

		public override double HitungGaji()
		{
			return 8000000;
		}
	}
}
