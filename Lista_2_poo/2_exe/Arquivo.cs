
//CRIANDO ARQUIVO 1 -------------------------------------------------------------
Console.WriteLine("Crie um arquivo:");
Console.WriteLine("Nome do arquivo:"); // NOME DO ARQUIVO
string? nome_arquivo = Console.ReadLine()!;
Arquivo arq1 = new Arquivo();
Console.WriteLine("Titulo do documento:"); // TITULO DO DOCUMENTO
string? titulo = Console.ReadLine()!;
Console.WriteLine("Conteudo do documento:"); // CONTEUDO DO DOCUMENTO
string? conteudo = Console.ReadLine()!;
Console.WriteLine(arq1.Criar(nome_arquivo, titulo, conteudo));


//ABRINDO ARQUIVO 1  -------------------------------------------------------------
Console.WriteLine("Abrir arquivo...:");
string? name_arquivo = Console.ReadLine()!;
Console.WriteLine(arq1.Abrir(name_arquivo));

//RENOMEANDO ARQUIVO 1 -------------------------------------------------------------

Console.WriteLine("\nDeseja renomear o arquivo?" +
                 "\n(R) Renomear " +
                 "\n(E) Editar " +
                 "\n(Outro) Sair");
string? Modo2 = Console.ReadLine()!;
if (Modo2 == "R")
{
    Console.WriteLine("Digite o novo nome do arquivo:");
    string? novo_nome = Console.ReadLine()!;
    Console.WriteLine(arq1.Renomear(novo_nome));
}
else if (Modo2 == "E") //EDITANDO ARQUIVO 1 -------------------------------------------------------------
{
    Console.WriteLine("Digite o novo titulo:");
    string? name = Console.ReadLine()!;
    Console.WriteLine("Digite o novo conteudo:");
    string? content = Console.ReadLine()!;
    Console.WriteLine(arq1.Editar(name, content));
}
else
{
    Console.WriteLine("Saindo...");
}

//EDITANDO ARQUIVO 1 -------------------------------------------------------------
/*string? Modo = Console.ReadLine()!;
if (Modo == "E")
{
    string? name = Console.ReadLine()!;
    string? content = Console.ReadLine()!;
    Console.WriteLine(arq1.Editar(name, content));
}
else
{

    Console.WriteLine(arq1.Abrir(name_arquivo));
}*/




