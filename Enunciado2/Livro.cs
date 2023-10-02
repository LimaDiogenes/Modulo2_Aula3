

namespace Aula3_Enunciado2
{
    internal class Livro
    {
        private string titulo;
        private string autor;
        private int paginas;

        /// <summary>
        /// Cria um objeto Livro. Parametros sao obrigatorios.
        /// </summary>
        /// <param name="titulo">"Titulo do livro</param>
        /// <param name="autor">"Autor do Livro"</param>
        /// <param name="paginas">"Quantidade de paginas do livro</param>
        internal Livro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo; this.autor = autor; this.paginas = paginas;
        }
    }
}
