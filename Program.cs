string frasedigitada, frasetonervoso, nome;
Console.Write("Olá, qual o seu nome?"); nome = Console.ReadLine()!;
Console.Write($"{nome}, me diga o que vc acha desse programa..."); frasedigitada = Console.ReadLine()!;

frasetonervoso = $"{frasedigitada.Remove(10)}... NÂO, PERA! Tô nervoso";
Console.WriteLine(frasetonervoso);
