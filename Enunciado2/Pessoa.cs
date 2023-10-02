
namespace Aula3_Enunciado2
{
    internal class Pessoa
    {
        internal string nome;
        internal string endereco;
        internal long telefone;
        internal long cpf;

        /// <summary>
        /// Cria um objeto Pessoa. Parâmetros sao obrigatórios.
        /// </summary>
        /// <param name="nome">"Nome completo do cliente"</param>
        /// <param name="endereco">"Endereco completo"</param>
        /// <param name="telefone">"Telefone (apenas digitos)"</param>
        /// <param name="cpf">"CPF (apenas digitos)"</param>

        internal Pessoa(string nome, string endereco, long telefone, long cpf)
        {
            this.nome = nome; this.endereco = endereco; this.telefone = telefone; this.cpf = cpf;
        }
    }
}
