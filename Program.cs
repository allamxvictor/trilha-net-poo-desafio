using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone(numero: "91234-5678", modelo: "Model 1", emei: "11111A1", memoria: 128);
Smartphone nokia = new Nokia(numero: "98765-4321", modelo: "Model 2", emei: "222222B2", memoria: 64);

Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");