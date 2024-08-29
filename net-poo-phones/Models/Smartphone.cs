using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_phones.Models
{
    public abstract class Smartphone
    {
        public int Number { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public int Memory {get; set;}

        public Smartphone(int number, string model, string imei, int memory){
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }
        public void MakeCall(){
            Console.WriteLine("Making a call");
        }

        public void ReceiveCall(){
            Console.WriteLine("Receiving a call");
        }
        public abstract void InstallApp(string nameApp);
    }
}