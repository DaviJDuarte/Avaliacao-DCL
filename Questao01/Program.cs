namespace Questao01;

class Program
{
    private const int MaximoAnos = 200;
    private const int MesesNoAno = 12;
    private const int DiasNoMes = 30;

    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade (anos, meses e dias):");

        var anos = LerEValidarInput("Anos:", 0, MaximoAnos);
        var meses = LerEValidarInput("Meses:", 0, MesesNoAno);
        var dias = LerEValidarInput("Dias:", 0, DiasNoMes);

        Idade idade = new Idade(anos, meses, dias);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Sua idade em dias é: {idade.IdadeEmDias()}");

        Console.ResetColor();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
    
    static int LerEValidarInput(string mensagem, int min, int max)
    {
        int valor;
        Console.WriteLine(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor) || !(min <= valor && valor < max))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Valor Inválido. Digite apenas números inteiros entre {min} e {max}");
            Console.ResetColor();
            Console.WriteLine(mensagem);
        }
        return valor;
    }
}

class Idade
{
    private const int DiasNoAno = 365;
    private const int DiasNoMes = 30;

    private int Anos { get; set; }
    private int Meses { get; set; }
    private int Dias { get; set; }

    public Idade(int anos, int meses, int dias)
    {
        Anos = anos;
        Meses = meses;
        Dias = dias;
    }

    public int IdadeEmDias()
    {
        var anosEmDias = Anos * DiasNoAno;
        var mesesEmDias = Meses * DiasNoMes;
        return anosEmDias + mesesEmDias + Dias;
    }
}