using System;
using DIO.Series.Classes;
using DIO.Series.Enum;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            // A linha abaixo causa erro pq nao eh possivel instanciar uma objeto de
            // _uma classe abstrata.
            // EntidadeBase minhaClasse = new EntidadeBase();

            string opcaoUsuario = obterOpcaoUsuario() ;

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        break;

                } //switch
                opcaoUsuario = obterOpcaoUsuario();

            } //while
            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.WriteLine();
            
            Console.WriteLine("Hello World!");
        } //Main
        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series ao seu dispor!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar series.");
            Console.WriteLine("2- Cadastrar nova sereie.");
            Console.WriteLine("3- Atualizar serie.");
            Console.WriteLine("4- Excluir serie.");
            Console.WriteLine("5- Visualizar serie. ");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        } //obterOpcaoUsuario()
        private static void ListarSeries()
        {
            //
            Console.WriteLine("Listar series.");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                //
                Console.WriteLine("Nenhuma serie cadastrada");
                //return;

            } //if
            foreach(var serie in lista)
                {
                    //
                    Console.WriteLine("#ID {0} - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), 
                        serie.retornaExcluido() ? "Indisponivel" : "Disponivel");

                } //foreach

            
        } //ListarSeries()
        private static void InserirSeries()
        {
            //
            Console.WriteLine("Inserir nova serie");
            foreach(int i in System.Enum.GetValues(typeof(Genero)))
            {
                //
                Console.WriteLine("{0} - {1}", i, System.Enum.GetName(typeof(Genero), i));

            } //foreach
            Console.WriteLine("Digita o genero conforme as opcoes acima");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita o titulo da serie");
            string entradaTitulo = Console.ReadLine();
            Console.WriteLine("Digite o ano de inicio da serie");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a descricao da serie");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);
            repositorio.Insere(novaSerie);

        } //InserirSeries
        private static void AtualizarSerie()
        {
            //
            Console.WriteLine("Digite o ID da serie:");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach(int i in System.Enum.GetValues(typeof(Genero)))
            {
                //
                Console.WriteLine("{0} - {1} ", i, System.Enum.GetName(typeof(Genero), i));
            } //foreach
            Console.Write("Selecione o Genero dentre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titulo da serie:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descricao da serie:");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);
            
            repositorio.Atualiza(indiceSerie, atualizaSerie);
            //
        } //AtualizarSerie()
        private static void ExcluirSerie()
        {
            //
            Console.Write("Digite o ID da serie:");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);

        } //ExcluirSerie()
        private static void VisualizarSerie()
        {
            //
            Console.Write("Digite o ID da serie:");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);

        } //VisualizarSerie()

    } //class program
} //namespace
