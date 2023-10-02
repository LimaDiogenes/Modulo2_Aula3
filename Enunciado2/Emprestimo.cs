
namespace Aula3_Enunciado2
{
    internal class Emprestimo
    {
        //Propriedades:
        private DateOnly DataEmprestimo { get; set; }
        private DateOnly DataEstorno { get; set; }
        private DateOnly DataEstimadaEstorno { get; set; }
        private Pessoa Pessoa { get; set; }
        private Livro Livro { get; set; }

        /// <summary>
        /// Metodo construtor. Necessita objetos Pessoa e Livro.
        /// </summary>

        internal Emprestimo(Pessoa pessoa, Livro livro)
        {
            this.Pessoa = pessoa;
            this.Livro = livro;
        }

        /// <summary>
        /// Solicita a data de emprestimo do livro, e a duracao do emprestimo. 
        /// 
        /// </summary>
        /// <returns>Retorna string com a data prevista de devolucao</returns>
        internal string Emprestar()
        {
            Console.WriteLine("Informe a data de empréstimo (dd/mm/yyyy):");
            if (DateOnly.TryParse(Console.ReadLine(), out DateOnly dataEmprestimo))

            {
                DataEmprestimo = dataEmprestimo;
            }
            Console.WriteLine("Informe a duração do empréstimo em número de dias:");
            if (int.TryParse(Console.ReadLine(), out int dias))
            {
                DataEstimadaEstorno = DataEmprestimo.AddDays(dias);
            }

            return $"Livro {Livro.titulo} emprestado dia {DataEmprestimo} para {Pessoa.nome}. Prazo para retorno: {DataEstimadaEstorno}";

        }
        /// <summary>
        /// Solicita a data em que o livro foi devolvido. Verifica se houve atraso na entrega.
        /// </summary>
        /// <returns>Retorna string com dias de atraso, ou sem atraso</returns>
        internal string Devolver() //retorna se houve atraso 
        {
            Console.WriteLine("Informe a data de devolução (dd/mm/yyyy):");
            if (DateOnly.TryParse(Console.ReadLine(), out DateOnly dataEstorno))
            {
                DataEstorno = dataEstorno;
            }
            
            if (DataEstorno > DataEstimadaEstorno)
            {
                TimeOnly hora = TimeOnly.MinValue;
                DateTime dataEstornoDateTime = DataEstorno.ToDateTime(hora);
                DateTime dataEstimadaEstornoDateTime = DataEstimadaEstorno.ToDateTime(hora);

                int dias = (dataEstornoDateTime - dataEstimadaEstornoDateTime).Days;

                return $"Devolvido com atraso de {dias} dias";
            }
            else 
            {
                return "Devolvido dentro do prazo";
            }
        }

}
}
