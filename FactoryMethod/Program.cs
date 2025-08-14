
// See https://aka.ms/new-console-template for more information

using FactoryMethod;

Console.WriteLine("==========Pizzaria============\n");
Console.WriteLine("Informe o local (S)ão Paulo ou (R)io de Janeiro");
var localEscolhido = Console.ReadLine()?.ToUpper();

Console.WriteLine("Informe a pizza (C)alabresa (M)ussarela");
var pizzaEscolhida = Console.ReadLine()?.ToUpper();

try
{
    var pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
    var pizza = pizzaria.MontaPizza(pizzaEscolhida);
    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("Pizza concluida com sucesso!");

}
catch (Exception e)
{
    Console.WriteLine("Erro: " + e.Message);
    throw;
}