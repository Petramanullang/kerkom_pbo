using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using pbo_kerkom.Interfaces;
using pbo_kerkom.Models;


namespace pbo_kerkom.Services
{
	public static class FileService
	{
		public static void SimpanKeFile(string namaFile, List<IKaryawan> data)
		{
			using (StreamWriter writer = new StreamWriter(namaFile))
			{
				foreach (IKaryawan karyawan in data)
				{
					writer.WriteLine(
						$"Nama: {karyawan.Nama}, " +
						$"Jabatan: {karyawan.Jabatan}, " +
						$"Gaji: {karyawan.HitungGaji()}"
					);
				}
			}
		}
	}
}
