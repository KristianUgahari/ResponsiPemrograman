using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2296
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("01012019", "Kristian", 10000000);
            Karyawan karyawan2 = new Karyawan("02012019", "Ugahari", 5000000);

            Console.WriteLine("No.	\tNIK/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1.	\t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. 	\t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine();

            karyawan1.GajiBulanan = karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 10/100);
            karyawan2.GajiBulanan = karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 10/100);

            Console.WriteLine("Assyiik... kenaikan gaji 10% !!!");
            Console.WriteLine();
            Console.WriteLine("No.	\tNIK/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1.	\t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.	\t{0} {1}\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.ReadKey();
        }
    }
}
