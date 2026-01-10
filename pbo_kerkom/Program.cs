using System;
using System.Collections.Generic;
using pbo_kerkom.Enums;
using pbo_kerkom.Exceptions;
using pbo_kerkom.Interfaces;
using pbo_kerkom.Models;
using pbo_kerkom.Services;
using System.IO;

namespace pbo_kerkom
{
	internal class Program
	{
		static void Main()
		{
			Console.Write("Masukkan jumlah karyawan: ");
			int jumlah = int.Parse(Console.ReadLine() ?? "0");

			List<IKaryawan> list = new List<IKaryawan>();

			for (int i = 0; i < jumlah; i++)
			{
				Console.WriteLine($"\nData Karyawan ke-{i + 1}");

				Console.Write("ID (angka > 0): ");
				int id = int.Parse(Console.ReadLine() ?? "0");

				Console.Write("Nama: ");
				string nama = Console.ReadLine() ?? "";

				Console.Write("Jabatan (Staf/Supervisor/Manajer): ");
				if (!Enum.TryParse(Console.ReadLine(), true, out Jabatan jabatan))
				{
					Console.WriteLine("Jabatan tidak valid. Isi: Staf/Supervisor/Manajer");
					i--;
					continue;
				}

				try
				{
					IKaryawan karyawan = jabatan switch
					{
						Jabatan.Staf => new Staf(id, nama),
						Jabatan.Supervisor => new Supervisor(id, nama),
						_ => new Manajer(id, nama)
					};

					double gaji = karyawan.HitungGaji();
					list.Add(karyawan);

					Console.WriteLine($"✅ Tersimpan: {karyawan.Nama} | {karyawan.Jabatan} | Gaji: {gaji}");
				}
				catch (GajiNegatifException ex)
				{
					Console.WriteLine($"❌ Error: {ex.Message}");
					i--;
				}
				catch (Exception ex)
				{
					Console.WriteLine($"❌ Error input: {ex.Message}");
					i--;
				}
			}

			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "dataKaryawan.txt");
			filePath = Path.GetFullPath(filePath);

			FileService.SimpanKeFile(filePath, list);
			Console.WriteLine($"\n✅ File disimpan di: {filePath}");
		}
	}
}
