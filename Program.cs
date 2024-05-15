using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine($"Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "345670", modelo: "Lumia 520", imei: "0125487856", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4785496", modelo: "Iphone 14 Pro", imei: "321654987", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
