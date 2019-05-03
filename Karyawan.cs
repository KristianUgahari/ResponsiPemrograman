using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2296
{
    class Karyawan
    {
        public string NIK, Nama;
        public int GajiBulanan;

        public Karyawan(string nik, string nama, int gaji)
        {
            if (gaji < 0)
            {
                gaji = 0;
            }

            NIK = nik;
            Nama = nama;
            GajiBulanan = gaji;
        }
    }
}
