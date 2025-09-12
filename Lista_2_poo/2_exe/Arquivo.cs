
Arquivo arq1 = new Arquivo();
Console.WriteLine(arq1.Criar("arquivo1.txt"));
Console.WriteLine("Digie o nome do arquivo:");
string? name_arquivo = Console.ReadLine()!;
Console.WriteLine(arq1.Abrir(name_arquivo));
/*
name_arquivo.Abrir($"{name_arquivo}");
Console.WriteLine("\nMudar para modo edição? (E)");
string modo = Console.ReadLine();
modo.Editar($"{modo}");*/