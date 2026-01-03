using System;

public class Supervisor : Karyawan, IKaryawan
{
    public override double getGaji()
    {
        return hitungGaji();
    }

    public double hitungGaji()
    {
        gaji = 5000000;

        if (gaji < 0)
            throw new GajiNegatifException("Gaji supervisor tidak boleh negatif!");

        return gaji;
    }
}
