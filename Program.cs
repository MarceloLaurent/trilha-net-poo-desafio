using DesafioPOO.Models;

Console.WriteLine("Testando o smartphone Noke:");

Smartphone nokia = new Nokia(numero: "12345", modelo: "Lumia 630", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Messenger");

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine("Testando o smartphone Noke:");

Smartphone iphone = new Iphone(numero: "54321", modelo: "XR", imei: "987654321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Messenger");
