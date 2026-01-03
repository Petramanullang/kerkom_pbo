using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public class Manajer : Karyawan, IKaryawan
    {
        public override double getGaji()
        {
            return hitungGaji();
        }

        public double hitungGaji()
        {
            gaji = 8000000;

            if (gaji < 0)
                throw new GajiNegatifException("Gaji manajer tidak boleh negatif!");

            return gaji;
        }
    }

}
