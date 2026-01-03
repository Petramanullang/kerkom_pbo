using System;
using System.Collections.Generic;
using System.Text;

namespace pbo_kerkom.Models
{
     internal abstract class Karyawan
    {
        public string NIP { get; set; }
        public string Nama { get; set; }
        public Jabatan Jabatan { get; set; }

        protected double gaji;

        public abstract double getGaji();
    }
}
