﻿using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("123", "1111111111", "Modelo 1", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatassp");



Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("123", "22222222", "Modelo 2", 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
