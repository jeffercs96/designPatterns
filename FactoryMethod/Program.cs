// See https://aka.ms/new-console-template for more information
using FactoryMethod;

BebidaEmbriagante bebida = Creador.CrearBebida(Creador.VINO_TINTO);

Console.WriteLine($"Me embriaga {bebida.CuantoMeEmbriagaPorHora()} por hora");