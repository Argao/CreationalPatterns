// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products.Interfaces;

IMontadora fabrica = new FabricaHonda();

var sedan =  fabrica.CriarSedan();
var suv = fabrica.CriarSuv();

Console.WriteLine("************** HONDA ************");
ExibeDetalhes(sedan, suv);


fabrica = new FabricaHyundai();

sedan =  fabrica.CriarSedan();
suv = fabrica.CriarSuv();

Console.WriteLine("************** HONDA ************");
ExibeDetalhes(sedan, suv);
return;
 
static void ExibeDetalhes(ISedan sedan1, ISuv suv1)
{
    Console.WriteLine(sedan1.ExibeDetalhes());
    Console.WriteLine(suv1.ExibeDetalhes());
}