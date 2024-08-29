using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_poo_phones.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(int number, string model, string imei, int memory): base(number, model, imei, memory){}

        public override void InstallApp(string nameApp){
            Console.WriteLine($"Installing {nameApp} on Nokia...");
        }
    }
}