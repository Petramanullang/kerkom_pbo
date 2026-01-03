using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan jumlah karyawan: ");
        int jumlah = int.Parse(Console.ReadLine());

        Karyawan[] dataKaryawan = new Karyawan[jumlah];
        string filePath = "dataKaryawan.txt";

        using (StreamWriter sw = new StreamWriter(filePath, true))
        {
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine($"\nData Karyawan ke-{i + 1}");
                Console.Write("NIP: ");
                string nip = Console.ReadLine();

                Console.Write("Nama: ");
                string nama = Console.ReadLine();

                Console.Write("Jabatan (STAF/SUPERVISOR/MANAJER): ");
                Jabatan jabatan = (Jabatan)Enum.Parse(typeof(Jabatan), Console.ReadLine().ToUpper());

                try
                {
                    Karyawan karyawan;

                    switch (jabatan)
                    {
                        case Jabatan.STAF:
                            karyawan = new Staf();
                            break;
                        case Jabatan.SUPERVISOR:
                            karyawan = new Supervisor();
                            break;
                        default:
                            karyawan = new Manajer();
                            break;
                    }

                    karyawan.NIP = nip;
                    karyawan.Nama = nama;
                    karyawan.Jabatan = jabatan;

                    double gaji = karyawan.getGaji();

                    dataKaryawan[i] = karyawan;

                    sw.WriteLine($"{nip},{nama},{jabatan},{gaji}");
                }
                catch (GajiNegatifException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        Console.WriteLine("\n=== DATA KARYAWAN DARI FILE ===");
        BacaData(filePath);
    }

    static void BacaData(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File tidak ditemukan.");
        }
    }
}
