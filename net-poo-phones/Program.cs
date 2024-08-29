using net_poo_phones.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(number: 4234512, model: "Modelo 12", imei: "123213312", memory: 64);
nokia.MakeCall();
nokia.ReceiveCall();
nokia.InstallApp("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(number: 3413434, model: "Modelo 15", imei: "21563432", memory: 128);
iphone.MakeCall();
iphone.ReceiveCall();
iphone.InstallApp("Telegram");