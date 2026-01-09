using System;
using System.Collections.Generic;
using System.Text;

namespace pbo_kerkom.Models
{
    public abstract class Karyawan : IKaryawan
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public Jabatan Jabatan { get; set; }

        protected Karyawan(int id, string nama, Jabatan jabatan)
        {
            Id = id;
            Nama = nama;
            Jabatan = jabatan;
        }

        public virtual double HitungGaji()
        {
            return Jabatan.TotalGaji();
        }

        public virtual string GetInfo()
        {
            return $"ID: {Id}, Nama: {Nama}, Jabatan: {Jabatan.NamaJabatan}, Gaji: {HitungGaji()}";
        }
    }
}
