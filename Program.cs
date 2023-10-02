
using System;

namespace Aula3_Enunciado1
{
    internal class Program
    {
        static void Main()
        {
            //Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. Cada objeto
            //dessa classe deve guardar os seguintes dados do aluno: matrícula, nome,
            //2 notas de prova e 1 nota de trabalho.
            //Escreva os seguintes métodos para esta classe:
            //registrar nota de cada prova e trabalho
            //calcula a média final do aluno(cada prova tem peso 2,5 e o trabalho tem peso 2).

            while (true)
            {
                try
                {
                    Console.WriteLine("Qual a matrícula do aluno? ");
                    int matricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o nome do aluno? ");
                    string nome = Console.ReadLine();
                    AlunoMatriculado FulanoDeTal = new AlunoMatriculado(matricula, nome);
                    Console.WriteLine($"\nNotas do Aluno:\n{FulanoDeTal.ConsultaNotas()}");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Entrada Inválida. Digite novamente.");
                }
            }          
            
        }

        internal class AlunoMatriculado
        {
            private int matricula;
            private string nome;
            private double notaProva1;
            private double notaProva2;
            private double notaTrabalho;

            /// <summary> 
            /// Registra a matrícula e o nome do aluno no objeto
            /// </summary>
            internal AlunoMatriculado(int matricula, string nome)
            {
                this.matricula = matricula;
                this.nome = nome;
                RegistrarNotas();
            }

            /// <summary> 
            /// Solicita e registra as notas do aluno
            /// </summary>
            private void RegistrarNotas()
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Qual a nota da prova 1? ");
                        notaProva1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a nota da prova 2? ");
                        notaProva2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a nota do trabalho? ");
                        notaTrabalho = double.Parse(Console.ReadLine());
                        Console.WriteLine(MediaFinal());
                        break;
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Entrada Invalida");
                    };
                    Console.ReadKey();
                }
            }

            /// <summary> 
            /// Calcula a média final do aluno, considerando pesos das provas / trabalho
            /// </summary>

            private string MediaFinal()
            {
                double media = ((notaProva1 * 2.5) + (notaProva2 * 2.5) + (notaTrabalho * 2)) / (2.5 + 2.5 + 2);
                return $"\nA média final do aluno {nome}, matricula {matricula} foi de {Math.Round(media, 2)}.";
            }

            /// <summary> 
            /// Consulta as notas registradas no objeto do aluno
            /// </summary>

            internal string ConsultaNotas()
            {
                return $"Nota da prova 1: {notaProva1}\n" +
                    $"Nota da prova 2: {notaProva2}\n" +
                    $"Nota do trabalho: {notaTrabalho}";
            }

        }
    }
}