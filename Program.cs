using System;

namespace MediaGeralPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do corso de C# Do professor Gabriel Artigas */

            // Aqui mudamos o titulo do console da nossa aplicação;
            Console.Title = "### Média Geral dos Alunos ###";

            // Aqui mudamos a cor da fonte;
            Console.ForegroundColor = ConsoleColor.Green;

            // Aqui capturamos a quantidade de alunos que serão avaliados;
            Console.Write("Quantos Alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Criando um array de objetos do tipo aluno;
            /* Obs.: A quantidade de alunos sara definida pelo valor da variavel nAlunos; */
            Aluno[] alunos = new Aluno[nAlunos];

            // Preencendo o array de alunos;
            for(int i = 0; i < alunos.Length; i++)
            {
                Console.Clear(); // esse comando limpa todo o console;

                // A cada Passagem do for, sera atribuido um nome a propiedade Nome da classe aluno;
                Console.Write($"Aluno #: {i+1} Nome..: ");
                string nome = Console.ReadLine();

                // A cada Passagem do for, sera atribuido um valor de quantas provas o aluno fez;
                Console.Write($"Aluno #: {i+1} Provas: ");
                int provas = int.Parse(Console.ReadLine());

                // A cada passagem do for, sera atribuido um valor de nota para a ou as provas do aluno;
                alunos[i] = new Aluno(nome, provas);
                Console.WriteLine($"Insira as notas do aluno: {nome}");

                // aqui chamamos o metodo que insere as notas;
                alunos[i].InserirNotas();
            }

            Console.Clear();

            // Criamos uma variavel que armazena um valor inicial de zero a media geral;
            double mediaGeral = 0;

            // Este Foreach atribui nome e media de cada aluno passado no array de Aluno;
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}"); // Exibe o nome;
                Console.WriteLine($"Media: {aluno.Media}"); // Exibe a Media;
                Console.WriteLine();
                mediaGeral += aluno.Media; // Atribui o valor + a media do aluno;
            }

            // A variavel resultadoFinal recebe mediaGeral dividido pela quantidade de alunos informada;
            double resultadoFinal = mediaGeral / alunos.Length; 

            // Exibimos os resultados Geral;
            Console.WriteLine($"A Media Geral dos alunos é: {resultadoFinal}");

            Console.ReadKey();
        }
    }
}
