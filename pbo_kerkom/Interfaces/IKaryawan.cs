using System;
using System.Collections.Generic;
using System.Text;

namespace pbo_kerkom.Interfaces
{
    internal class Ikaryawan
    {
        int Id { get; set; }
        string Nama { get; set; }
        Jabatan Jabatan { get; set; }

        double HitungGaji();
        string GetInfo();
    }
}
