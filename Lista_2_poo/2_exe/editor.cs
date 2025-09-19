public class Arquivo
{
    // Atributos
    public string Name { get; set; }
    public string Titulo { get; set; }
    public int Size { get; set; }
    public string Content { get; set; }
    // atributos

    // Construtores = inicializa os atributos da classe com algum valor
    public Arquivo() // tem que ser publico e ter o mesmo nome da classe
    {
        Name = "Sem nome";
        Titulo = "Sem titulo";
        Content = "Vazio";
        Size = Calculartamanho(); // Inicializa o saldo como zero
        //Console.WriteLine("Arquivo " + Name + " criado com sucesso!");
    }


    // Métodos

    private int Calculartamanho()
    {
        return Content.Length * 8; // Cada caractere é 1 byte, multiplicado por 8 para bits
    }


    public string Criar(string name, string titulo, string conteudo)
    {


        if (name != "")
        {
            Name = name;
            Titulo = titulo;
            Content = conteudo;
            return "\nArquivo " + Name + " criado com sucesso!" +
                   "\nTitulo do arquivo: " + Titulo +
                   "\nConteúdo do arquivo: " + Content + "\n";
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
            return "\n\nArquivo " + Name + " aberto com sucesso!\n" +
                   "-------------------------------"+
                   "\nTitulo do arquivo: " + Titulo +
                   "\nTamanho do arquivo: " + Size +
                    "\nConteúdo do arquivo: " + Content;
        }
        else
        {
            return "Arquivo não encontrado!";
        }
    }
    public string Renomear(string name)
    {
        

        Name = name;
        return $"\n Titulo: {Name} atualizado!";
    }

    public string Editar(string name, string content)
    {

        Name = name;
        Content = content;
        return $"\n Titulo: {Name}"
              + $"\n Conteudo: {Content}";
    }
}

