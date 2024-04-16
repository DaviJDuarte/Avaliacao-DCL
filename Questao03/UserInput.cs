namespace Questao03;

// Métodos para validar que o usuário está digitando uma entrada esperada.
// No caso deste programa, é necessário garantir que são sempre números positivos

static class UserInput
{
    public static T LerEValidarInput<T>(string mensagem) where T : IConvertible
    {
        T valor;
        Console.WriteLine(mensagem);
        while (!TryParse(Console.ReadLine(), out valor) || Convert.ToDouble(valor) < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor Inválido.");
            Console.ResetColor();
            Console.WriteLine(mensagem);
        }

        return valor;
    }

    private static bool TryParse<T>(string input, out T valor) where T : IConvertible
    {
        try
        {
            valor = (T)Convert.ChangeType(input, typeof(T));
            return true;
        }
        catch
        {
            valor = default(T);
            return false;
        }
    }
}