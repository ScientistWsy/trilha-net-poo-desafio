using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "123456789", "64GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("11988888888", "iPhone 13", "987654321", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");