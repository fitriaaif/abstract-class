using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "21114272";
            mhs.nama = "Fitria Amanda";
            mhs.email = "fitriaaif@students.amikom.ac.id";

            Console.WriteLine("            KONVERSI DATA            ");
            Console.WriteLine("=====================================");
            Console.WriteLine("Pilihan Format Konversi Data: ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. CSV\n");

            Console.Write("Nomor format data yang dipilih [1-3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            ConvertObject convert; // deklarasi objek konversi

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            // konversi objek mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}