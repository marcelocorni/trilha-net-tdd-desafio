using Batalha.Models;
using Batalha.Controllers;

namespace Batalha.Tests;

public class BatalhaMonstroTest
{
    private (Monstro monstro1, Monstro monstro2) CriarMonstroDefault()
    {
        Monstro monstro1 = new Monstro
        {
            Nome = "Monstro 1",
            Vida = 100,
            Ataque = 10,
            Defesa = 5,
            Nivel = 1
        };

        Monstro monstro2 = new Monstro
        {
            Nome = "Monstro 2",
            Vida = 100,
            Ataque = 10,
            Defesa = 5,
            Nivel = 1
        };

        return (monstro1, monstro2);
    }
    
    private (Monstro vencedor,Monstro perdedor, BatalhaMonstro batalha) RetornarVencedor()
    {
        var (monstro1, monstro2) = CriarMonstroDefault();
        BatalhaMonstro batalha = new BatalhaMonstro(monstro1, monstro2);
        var (vencedor, perdedor) = batalha.Batalhar();
        return (vencedor,perdedor, batalha);
    }

    [Fact]
    public void BatalhaSempreRetornaUmMonstroVencedor()
    {
        var (vencedor, _,_) = RetornarVencedor();

        Assert.NotNull(vencedor);
    }

    [Fact]
    public void SubirNivelAumentaNivelDoMonstroVencedorEm1()
    {
        var (vencedor,_, batalha) = RetornarVencedor();

        var resultadoEsperado = vencedor.Nivel + 1;

        batalha.SubirNivel(ref vencedor);

        Assert.Equal(resultadoEsperado, vencedor.Nivel);
    }

    [Fact]
    public void SubirNivelAumentaAtaqueDoMonstroVencedorEm5()
    {
        var (vencedor,_, batalha) = RetornarVencedor();
        var resultadoEsperado = vencedor.Ataque + 5;
        batalha.SubirNivel(ref vencedor);
        Assert.Equal(resultadoEsperado, vencedor.Ataque);
    }

    [Fact]
    public void SubirNivelAumentaDefesaDoMonstroVencedorEm2()
    {
        var (vencedor,_, batalha) = RetornarVencedor();
        var resultadoEsperado = vencedor.Defesa + 2;
        batalha.SubirNivel(ref vencedor);
        Assert.Equal(resultadoEsperado, vencedor.Defesa);
    }

    [Fact]
    public void SubirNivelAumentaVidaDoMonstroVencedorEm50()
    {
        var (vencedor,_, batalha) = RetornarVencedor();
        var resultadoEsperado = vencedor.Vida + 50;
        batalha.SubirNivel(ref vencedor);
        Assert.Equal(resultadoEsperado, vencedor.Vida);
    }

    [Fact]
    public void MonstroPerdedorSempreFicaComVidaZero()
    {
        var (_,perdedor,_) = RetornarVencedor();
        Assert.Equal(0, perdedor.Vida);
    }
}