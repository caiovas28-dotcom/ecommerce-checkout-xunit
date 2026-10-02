using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveRetornarCodigoFormatado()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.GerarCodigoRastreio("sudeste", 42);

        // Assert
        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveRetornar30Pontos()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.CalcularPontosFidelidade(150);

        // Assert
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_DeveRetornarTrueParaClienteVIP()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.TemDireitoAFreteGratis(150, true);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_DeveRetornarFalseParaNaoVIPAbaixoDe200()
    {
        // Arrange
        var service = new PedidoService();

        // Act
        var resultado = service.TemDireitoAFreteGratis(150, false);

        // Assert
        Assert.False(resultado);
    }
}
