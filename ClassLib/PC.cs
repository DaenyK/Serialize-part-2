using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        // public PC() { }
        public PC(string title, string serialNumber, string model, double price)
        {
            Title = title;
            SerialNumber = serialNumber;
            Model = model;
            Price = price;
        }
        public string Title { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public double Price
        {
            get; set;
        }

        [NonSerialized]
        public int Id;
    }
}
