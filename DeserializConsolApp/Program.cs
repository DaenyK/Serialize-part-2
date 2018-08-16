using ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\ДК\listSerial.txt", FileMode.OpenOrCreate))
            {
                var result = (List<PC>)formatter.Deserialize(fs);
                Console.WriteLine("объект десериализирован");
                foreach (PC item in result)
                {
                    Console.WriteLine(item.Title + "\t" + item.Model + "\t" + item.SerialNumber + "\t" + item.Price);
                }
            }
        }

    }
}
