using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o nome do aluno {i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Informe a nota do aluno {nome}: ");
                int nota = Convert.ToInt32(Console.ReadLine());

                Aluno aluno = new Aluno();
                aluno.Nome = nome;
                aluno.Nota = nota;

                alunos.Add(aluno);
            }

            List<Aluno> alunosOrdenados = alunos.OrderBy(a => a.Nome).ToList();
            double media = alunos.Average(a => a.Nota);


                /*string[,] nomes = new string[10,2];
                string[,] nomesBackup = new string[10, 2];

                string[] nomesParaOrdenar = new string[10];
                int somaNotas = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Informe o nome do aluno {i+1}: ");
                    string nome = Console.ReadLine();
                    nomes[i, 0] = nome;
                    nomesBackup[i, 0] = nome;
                    nomesParaOrdenar[i] = nome;

                    Console.Write($"Informe a nota do aluno {nomes[i,0]}: ");
                    string nota = Console.ReadLine();
                    nomes[i, 1] = nota;
                    nomesBackup[i, 1] = nota; ;

                    somaNotas += Convert.ToInt32(nomes[i, 1]);
                }

                double media = somaNotas / 10;

                //Ordenação
                Array.Sort(nomesParaOrdenar);
                for (int i = 0; i < nomesParaOrdenar.Length; i++)
                {
                    nomes[i, 0] = nomesParaOrdenar[i];
                    for (int j = 0; j < nomesParaOrdenar.Length; j++)
                    {
                        if (nomesParaOrdenar[i] == nomesBackup[j, 0])
                        {
                            nomes[i, 1] = nomesBackup[j, 1];
                        }
                    }
                }


                for (int i = 0; i < nomesParaOrdenar.Length; i++)
                {
                    Console.WriteLine($"Nome {i+1}: {nomes[i,0]} ");
                }
                Console.WriteLine($"Média da turma: {media}");

                Console.ReadLine();
                */























                /*string[,] notas = new string[3,2];

                notas[0, 0] = "João";
                notas[0, 1] = "10";
                notas[1, 0] = "Antônio";
                notas[1, 1] = "8";
                notas[2, 0] = "Maria";
                notas[2, 1] = "7";

                string[,] backup = new string[3, 2];

                backup[0, 0] = "João";
                backup[0, 1] = "10";
                backup[1, 0] = "Antônio";
                backup[1, 1] = "8";
                backup[2, 0] = "Maria";
                backup[2, 1] = "7";

                string[] nomes = { "João", "Antônio", "Maria" };
                Array.Sort(nomes);

                for(int i = 0; i<nomes.Length;  i++)
                {
                    notas[i, 0] = nomes[i];
                    for (int j = 0; j < 3; j++)
                    {
                        if (nomes[i] == backup[j, 0])
                        {
                            notas[i, 1] = backup[j, 1];
                        }
                    }
                }
                Console.ReadLine();*/
            }
    }
}
