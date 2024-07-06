using System;
using Models;

Nokia nokia1 = new("", "1", "1019", 100);
Iphone iphone1 = new("", "1", "10220", 10);

Console.WriteLine("Infos do nokia: ");
Console.WriteLine(" ");

nokia1.Infos();
nokia1.RecebendoLigacao();
nokia1.Ligar();
nokia1.InstalarApp("whats");
nokia1.Numero = "321";
nokia1.Infos();

Console.WriteLine(" ");
Console.WriteLine("Infos do iphone: ");
Console.WriteLine(" ");

iphone1.Infos();
iphone1.RecebendoLigacao();
iphone1.Ligar();
iphone1.InstalarApp("whats");
iphone1.Numero = "123";
iphone1.Infos();