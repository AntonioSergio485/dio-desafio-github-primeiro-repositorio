using System;



namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {            
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break; 
                    case "3":
                        AtualizarSeries();
                    break; 
                    case "4":                        
                        ExcluirSerie();
                    break; 
                    case "5":
                        VisualizarSerie();
                    break;     
                    case "C":
                        Console.Clear();
                    break; 
                    
                    default:
                     System.Console.WriteLine("Erro");
                     break;
                } 

                opcaoUsuario = ObterOpcaoUsuario();  
            }   
        }

        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o id da série");  
            int id = int.Parse(Console.ReadLine());  

            var serie = repositorio.RetornaPorId(id);
            System.Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o id para excluir");
            int id = int.Parse(Console.ReadLine());
            repositorio.Excluir(id);
        }

        private static void AtualizarSeries()
        {
            System.Console.WriteLine("Digite o id da série");
            int indice = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));    
            }

            System.Console.WriteLine("Digite o genêro entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o titulo da série");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano da série");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: indice,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);

            repositorio.Atualizar(indice,novaSerie);
        }

        private static void InserirSerie()
        {
            System.Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));    
            }
            
            System.Console.WriteLine("Digite o genêro entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o titulo da série");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano da série");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);

            repositorio.Insere(novaSerie);
        }

        public static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar séries ");
            Console.WriteLine("2- Inserir nova serie ");
            Console.WriteLine("3- Atualizar série ");
            Console.WriteLine("4- Excluir série ");
            Console.WriteLine("5- Visualizar série ");
            Console.WriteLine("C- Limpar tela ");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarSeries(){
            System.Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                System.Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                System.Console.WriteLine("#ID {0}: {1} {2}",serie.retornaId(),serie.retornaTitulo(),(excluido ? "Excluido" : ""));
            }
        }
    }
}
