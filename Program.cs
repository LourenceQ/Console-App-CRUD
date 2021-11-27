using System;

namespace DIO.Series
{
    class Program
    {
        static SeriesRepository repository = new SeriesRepository();

        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while(userOption.ToUpper() != "x")
            {
                switch(userOption)
                {
                    case "1":
                        ListingSeries();
                        break;
                    case "2":
                        InsertSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        DeleteSeries();
                        break;
                    case "5":
                        //QuerySeries();
                        break;
                    case "C":
                        //Clear();
                        break;
                    default:
                    throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviçoes.");
            Console.ReadLine();
        }

        private static void ListingSeries()
        {
            Console.WriteLine("Listar séries");

            var list = repository.Listing();;

            if(list.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in list)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.IdReturn(), serie.TitleReturn());
            }
        }
        private static void InsertSeries()
        {
            Console.WriteLine("Inserir uma série");

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} {1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima:" );
            int genreInsert = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: " );
            string titleInsert = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série: " );
            int yearInsert = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descriçao da série: " );
            string descriptionInsert = Console.ReadLine();
            
            Series newSerie = new Series(id: repository.NextId(),
                                        genre: (Genre)genreInsert,
                                        title: titleInsert,
                                        year: yearInsert,
                                        description: descriptionInsert);
            repository.Insert(newSerie);
            
        }
        private static void UpdateSeries()
        {
            Console.Write("Digite o id da série: ");
            int indexSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i , Enum.GetName(typeof(Genre), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int genreInput = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da Série: ");
            string titleInput = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int yearInput = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descriçao da Série: ");
            string descriptionInput = Console.ReadLine();    

            Series updateSerie = new Series(id: indexSerie,
                                        genre: (Genre)genreInput,
                                        title: titleInput,
                                        year: yearInput,
                                        description : descriptionInput);        

            repository.Update(indexSerie, updateSerie);
        }
        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor !!!");
            Console.WriteLine("Favor informar a opção desejada:");

            Console.WriteLine("1- Lista de Séries");
            Console.WriteLine("2- Inserir uma nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
        private static void DeleteSeries()
        {
            Console.WriteLine("Informe o id da série: ");
            int serieIndex = int.Parse(Console.ReadLine());

            repository.Delete(serieIndex);
        }
    }
}
