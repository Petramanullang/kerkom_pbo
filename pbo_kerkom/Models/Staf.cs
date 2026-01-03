using System;

public class Staf : Karyawan, IKaryawan
{
    public override double getGaji()
    {
        return hitungGaji();
    }

    public double hitungGaji()
    {
        gaji = 3000000;

        if (gaji < 0)
            throw new GajiNegatifException("Gaji staf tidak boleh negatif!");

        return gaji;
    }
}
