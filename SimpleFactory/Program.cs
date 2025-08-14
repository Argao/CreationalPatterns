using SimpleFactory;

Console.WriteLine("==========Pizzaria============\n");
Console.WriteLine("Informe a pizza (C)alabresa (M)ussarela");
var pizzaEscolhida = Console.ReadLine()?.ToUpper();
try
{
    //===============Sem Simple Factory======================
    // Pizza pizza;
    // switch (pizzaEscolhida)
    // {
    //     case "C":
    //         pizza = new PizzaCalabresa();
    //         break;
    //     case "M":
    //         pizza = new PizzaMussarela();
    //         break;
    //     default:
    //         Console.WriteLine("A pizza não pode ser criada");
    //         throw new Exception();
    //         break;
    // }
    
    var pizza = PizzaSimpleFactory.CriarPizza(pizzaEscolhida);
    
    pizza.Preparar();
    pizza.Assar(20);
    pizza.Embalar();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
