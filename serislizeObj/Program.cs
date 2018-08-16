using ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace serislizeObj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pcList = new List<PC>();
            pcList.Add(new PC("pentium", Guid.NewGuid().ToString(), "mark1", 5000) { Id = 1});
            pcList.Add(new PC("lenovo", Guid.NewGuid().ToString(), "mark2", 5000) { Id = 2 });
            pcList.Add(new PC("acer", Guid.NewGuid().ToString(), "mark3", 5000) { Id = 3 });
            pcList.Add(new PC("apple", Guid.NewGuid().ToString(), "mark4", 5000) { Id = 4 });


            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\ДК\listSerial.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, pcList);
                Console.WriteLine("объект сериализирован");
            }
        }
    }
}
