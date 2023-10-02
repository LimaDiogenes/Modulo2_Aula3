namespace Aula3_Enunciado2;
using System.Globalization;


internal class Program
    {
        static void Main()
        {
        CultureInfo cultureInfo = new CultureInfo("pt-BR");
        System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;

        // cliente: 
        //Pessoa pessoa1 = new("José da Silva", "Rua Brasil, 1558", 99789658231, 01234567890);
        Console.WriteLine("Nome Completo: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Endereço completo: ");
        string endereco = Console.ReadLine();
        Console.WriteLine("Endereço telefone (apenas dígitos): ");
        long telefone = long.Parse(Console.ReadLine());
        Console.WriteLine("Endereço CPF (apenas dígitos): ");
        long cpf = long.Parse(Console.ReadLine());
        Pessoa pessoa1 = new(nome, endereco, telefone, cpf); //objeto pessoa
        // livro:
        Console.WriteLine("Título do Livro: ");
        string titulo = Console.ReadLine();
        Console.WriteLine("Quantidade de páginas: ");
        int paginas = int.Parse(Console.ReadLine());
        Console.WriteLine("Autor: ");
        string autor = Console.ReadLine();
        Livro livro1 = new(titulo, autor, paginas); // objeto livro
        // instanciando objeto emprestimo, usando os objetos acima como parametros
        Emprestimo emprestimo = new(pessoa1, livro1);

        Console.WriteLine(emprestimo.Emprestar()); // metodo para emprestar
        Console.WriteLine(emprestimo.Devolver()); // metodo para devolver
        }
    }
