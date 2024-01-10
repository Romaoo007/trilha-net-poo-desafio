﻿using DesafioCelular.Models;

Smartphone nokia = new Nokia("947948446", "Nokia", "123321", 500);
nokia.InstalarAplicativo("whatsApp");
nokia.InstalarAplicativo("Pinterest");
nokia.InstalarAplicativo("Instagram");
nokia.ApresentacaoSmartphone();
nokia.ExibirListaDeApps();


Smartphone iphone = new Iphone("994350982", "iphone", "9876543", 600);
iphone.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("GARTIC");
iphone.InstalarAplicativo("Snapchat");
iphone.ApresentacaoSmartphone();
iphone.ExibirListaDeApps();