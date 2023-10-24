using DesafioPOO.Models;

//implementado
Console.WriteLine("Smartphone Nokia:");
Nokia n1 = new Nokia(numero: "123456", modelo: "modelo nokia 1", imei: "111111111", memoria: 16);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("instagram");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Iphone i1 = new Iphone(numero: "78910", modelo: "modelo iphone 1", imei: "2222222", memoria: 32);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("facebook");