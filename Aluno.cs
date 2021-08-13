using System;

namespace MediaGeralPoo
{
    class Aluno
    {
        // Esta Propiedade obtem e define o nome do aluno;
        public string Nome { get; private set; }

        // Este array serve para armazenar todas as notas das provas do aluno;
        private double[] _notas;

        // Esta Propiedade Retorna a Media do Aluno;
        public double Media 
        {
            get
            {
                return CalcularMedia();
            }
        }

        // Metodo Construtor da classe;
        public Aluno(string nome, int provas)
        {
            // a propiedade Nome vai receber o nome passado entre parametros;
            Nome = nome;

            // Aqui inicializamos o array que armazena as notas do aluno;
            /* Obs.: Este array armazenara uma quantidade equivalente as
             * provas feitas pelo aluno, ou seja, o valor passado entre parametros
             para o valor provas */

            _notas = new double[provas];
        }

        // Este Metodo insere os valores das Notas;
        public void InserirNotas()
        {
            /* este for sera executado de acordo com o tamanho do valor
             passado para a quantidade de provas inicializadas no array de notas; */
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write($"Nota # {i+1}: ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        // Este metodo serve pra calcular a media do aluno;
        private double CalcularMedia()
        {
            double total = 0;

            for(int i = 0; i < _notas.Length; i++)
            {
                /* Aqui sera atribuido a variavel total, o seu propio valor + o valor do indice 
                 de _notas na posiçao i */
                total += _notas[i];
            }
            return total / _notas.Length;
        }

    }
}
