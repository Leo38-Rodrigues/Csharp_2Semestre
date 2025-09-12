
Arquivo arq1 = new Arquivo();
Console.WriteLine(arq1.Criar("arquivo1.txt"));
Console.WriteLine("Digite o nome do arquivo:");
string? name_arquivo = Console.ReadLine()!;
//ABRINDO ARQUIVO 1
Console.WriteLine(arq1.Abrir(name_arquivo));

Console.WriteLine("Deseja editar o arquivo? (E)");
string? Modo = Console.ReadLine()!;
if (Modo == "E")
{
    string? name = Console.ReadLine()!;
    string? content = Console.ReadLine()!;
    Console.WriteLine(arq1.Editar(name, content));
}

/*
name_arquivo.Abrir($"{name_arquivo}");
Console.WriteLine("\nMudar para modo edição? (E)");
string modo = Console.ReadLine();
modo.Editar($"{modo}");*/