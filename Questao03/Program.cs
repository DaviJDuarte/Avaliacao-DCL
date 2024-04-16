namespace Questao03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora - Salário Final dos Vendedores");
        var salarioFixo = UserInput.LerEValidarInput<double>("Digite o salário fixo do vendedor (reais):");
        var comissaoFixaPorCarro = UserInput.LerEValidarInput<double>(
            "Digite quanto o vendedor ganha de comissão por cada carro vendido (reais):"
        );
        var carrosVendidos = UserInput.LerEValidarInput<int>("Digite quantos carros ele vendeu:");
        var valorTotalVendas = UserInput.LerEValidarInput<double>(
            "Digite o valor total das vendas feitas (reais):"
        );

        var vendedor = new Vendedor(salarioFixo, comissaoFixaPorCarro);
        var salarioFinal = vendedor.CalcularSalarioFinal(carrosVendidos, valorTotalVendas);

        Console.WriteLine($"O salário final do vendedor é: R${salarioFinal:0.00}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}