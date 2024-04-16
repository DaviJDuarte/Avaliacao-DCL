namespace Questao03;

public class Vendedor(double salarioFixo, double comissaoPorCarro)
{
    private const float ComissaoFixaVendaTotal = 0.05F; // 5%

    public double CalcularSalarioFinal(int carrosVendidos, double valorTotalVendas)
    {
        var totalComissaoPorCarro = carrosVendidos * comissaoPorCarro;
        var totalComissaoVendas = ComissaoFixaVendaTotal * valorTotalVendas;

        return salarioFixo + totalComissaoPorCarro + totalComissaoVendas;
    }
}