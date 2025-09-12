public class Arquivo
{
    // Atributos
    public string Name { get; set; }
    public int Size { get; set; }
    public string Content { get; set; }
    // atributos

    // Construtores = inicializa os atributos da classe com algum valor
    public Arquivo() // tem que ser publico e ter o mesmo nome da classe
    {
        Name = "Sem titulo";
        Size = 8; // Inicializa o saldo como zero
        Content = "Vazio";
        //Console.WriteLine("Arquivo " + Name + " criado com sucesso!");
    }


    // Métodos

    public string Criar(string name)
    {


        if (name != "")
        {
            Name = name;
            return "Arquivo " + Name + " criado com sucesso!";
        }
        else
        {
            return "Nome inválido!";
        }

    }
    public string Abrir(string name_arquivo)
    {
        if (Name == name_arquivo)
        {
            return "Arquivo " + Name + " aberto com sucesso!\n" +
                   "\nTitulodo arquivo: " + Name +
                   "\nTamanho do arquivo: " + Size +
                    "\nConteúdo do arquivo: " + Content;
        }
        else
        {
            return "Arquivo não encontrado!";
        }
    }
    /*
    public string Editar(string modo, string name_arquivo, int size, string content)
    {
        if (Name == Name && modo == "E")
        {
            Name = Console.ReadLine();
            Size = int.Parse(Console.ReadLine());
            Content = Console.ReadLine();
            Console.WriteLine("Arquivo " + Name + "aberto com sucesso!");
            Console.WriteLine("Tamanho do arquivo: " + Size,
                            "\nConteúdo do arquivo: " + Content);
        }
    }*/
}

