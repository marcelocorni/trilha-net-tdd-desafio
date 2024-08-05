// See https://aka.ms/new-console-template for more information

using Batalha.Controllers;
using Batalha.Models;

Console.WriteLine("Batalha de Monstros!");
BatalhaMonstro batalha = new BatalhaMonstro(new ("Monstro1"), new ("Monstro 2"));

var (vencedorBatalha1, perdedorBatalha1) = batalha.Batalhar();
batalha.SubirNivel(ref vencedorBatalha1);

Console.WriteLine($"O vencedor da batalha foi: {vencedorBatalha1.Nome}");
Console.WriteLine($"Vencedor: {vencedorBatalha1.Nome} - Vida: {vencedorBatalha1.Vida} - Nível: {vencedorBatalha1.Nivel} - Ataque: {vencedorBatalha1.Ataque} - Defesa: {vencedorBatalha1.Defesa}");
Console.WriteLine($"Perdedor: {perdedorBatalha1.Nome} - Vida: {perdedorBatalha1.Vida} - Nível: {perdedorBatalha1.Nivel} - Ataque: {perdedorBatalha1.Ataque} - Defesa: {perdedorBatalha1.Defesa}");
Console.WriteLine("\nO Vencedor irá batalhar novamente com um novo monstro!");

batalha = new BatalhaMonstro(vencedorBatalha1, new Monstro("Monstro 3"));
var (vencedorBatalha2, perdedorBatalha2) = batalha.Batalhar();
batalha.SubirNivel(ref vencedorBatalha2);

Console.WriteLine($"O vencedor da batalha foi: {vencedorBatalha1.Nome}");
Console.WriteLine($"Vencedor: {vencedorBatalha2.Nome} - Vida: {vencedorBatalha2.Vida} - Nível: {vencedorBatalha2.Nivel} - Ataque: {vencedorBatalha2.Ataque} - Defesa: {vencedorBatalha2.Defesa}");
Console.WriteLine($"Perdedor: {perdedorBatalha2.Nome} - Vida: {perdedorBatalha2.Vida} - Nível: {perdedorBatalha2.Nivel} - Ataque: {perdedorBatalha2.Ataque} - Defesa: {perdedorBatalha2.Defesa}");

Console.ReadLine();



