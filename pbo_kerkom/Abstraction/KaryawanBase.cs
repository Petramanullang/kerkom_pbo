using pbo_kerkom.Interfaces;
using pbo_kerkom.Enums;
using System;

namespace pbo_kerkom.Abstracts
{
	public abstract class KaryawanBase : IKaryawan
	{
		public int Id { get; protected set; }
		public string Nama { get; set; }
		public Jabatan Jabatan { get; set; }

		protected KaryawanBase(int id, string nama, Jabatan jabatan)
		{
			if (id <= 0)
				throw new ArgumentException("ID harus lebih dari 0");

			if (string.IsNullOrWhiteSpace(nama))
				throw new ArgumentException("Nama tidak boleh kosong");

			Id = id;
			Nama = nama;
			Jabatan = jabatan;
		}

		// Kontrak interface
		public abstract double HitungGaji();

		public virtual string GetInfo()
		{
			return $"ID: {Id}, Nama: {Nama}, Jabatan: {Jabatan}";
		}
	}
}
