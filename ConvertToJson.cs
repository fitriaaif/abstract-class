using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Abstraction
{
    public class ConvertToJson : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            // konversi objek mahasiswa ke Json
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("\nHasil konversi ke Json: ");
            Console.WriteLine(json);
        }
    }
}