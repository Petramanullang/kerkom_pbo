using System;
using System.Collections.Generic;
using pbo_kerkom.Interfaces;
using pbo_kerkom.Models;
using pbo_kerkom.Services;

namespace pbo_kerkom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<IKaryawan> daftarKaryawan = new List<IKaryawan>
				{
					new Staf("Andi", 3000000),
					new Supervisor("Budi", 5000000),
					new Manajer("Citra", 8000000)
				};

				FileService.SimpanKeFile("dataKaryawan.txt", daftarKaryawan);

				Console.WriteLine("Data karyawan berhasil disimpan ke file.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Terjadi kesalahan:");
				Console.WriteLine(ex.Message);
			}
		}
	}
}
