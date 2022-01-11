using DIO.SERIES;

static class Program
{
    static GerenciadorAnimes gerenciadorAnimes = new GerenciadorAnimes();
    public static void Main(string[] args)
    {
        string opcaoUsuario = ObterOpcaoUsuario();
        while(opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarAnimes();
                    break;
                case "2":
                    InserirAnime();
                    break;
                case "3":
                    //AtualizarAnime();
                    break;
                case "4":
                    //ExcluirAnime();
                    break;
                case "5":
                    //VisualizarAnime();
                    break;
                case "C":
                    Console.Clear();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
                    
            }
           
            opcaoUsuario = ObterOpcaoUsuario();
        }
        Console.WriteLine("Obrigado por utilizar nossos seviços");
        Console.ReadLine();
    }
    private static void ListarAnimes()
    {
        Console.WriteLine("Listar Anime");
        var lista = gerenciadorAnimes.Lista();
        if(lista.Count == 0)
        {
            Console.WriteLine("Nenhuma série cadastrada");
            return;
        }
        foreach(var anime in lista)
        {
            Console.WriteLine("#ID {0}: - {1}", anime.retornaId(), anime.retornaNome());
        }
    }
    private static void InserirAnime()
    {
        Console.WriteLine("Adicione um novo anime");
        foreach(int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.WriteLine("Digite o gênero entre as opções acima: ");
        int generoEscolhido = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Nome do Anime: ");
        string nomeAnime = Console.ReadLine();
        Console.WriteLine("Digite o ano de lançamento do anime");
        int anoEscolhido = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a descrição do anime");
        string descriçãoEscolhida = Console.ReadLine();

        Anime novoAnime = new Anime(id: gerenciadorAnimes.ProximoId(),
            genero: (Genero)generoEscolhido,
            nome: nomeAnime,
            descricao: descriçãoEscolhida,
            ano: anoEscolhido
        );
        gerenciadorAnimes.Insere(novoAnime);
         


    }
    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("DIO ANIMES!!");
        Console.WriteLine("Qual sua opção: ");
        Console.WriteLine("[1] - Listar Anime\n" +
            "[2] - Inserir novo anime\n" +
            "[3] - Atualizar anime\n" +
            "[4] - Excluir animen\n" +
            "[5] - Visualizar anime\n" +
            "[X] - Sair\n" +
            "[C] - Limpar Tela");
        Console.WriteLine();
        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }
}

