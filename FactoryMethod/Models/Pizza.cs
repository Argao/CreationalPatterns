using System.Collections;
using System.Text;

namespace FactoryMethod;

public abstract class Pizza
{
    protected string? Nome { get; set; }
    protected string? massa;
    protected string? molho;
    protected ArrayList ingredientes = new ArrayList();


    public string Preparar()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Preparando pizza de {Nome}\n");
        sb.AppendLine($"Massa: {massa}\n");
        sb.AppendLine($"Molho: {molho}\n");
        sb.AppendLine("Ingredientes: \n");
        foreach (var ingrediente in ingredientes)
        {
            sb.AppendLine("\t" + ingrediente + "\n");
        }
        sb.AppendLine(Cozinhar());
        sb.AppendLine(Fatiar());
        sb.Append(Embalar());
        return sb.ToString();
    }
    
    public virtual string Cozinhar() => "Cozinhar por 25 minutos a 350 graus\n";
    
    public virtual string Fatiar() => "Fatiar a pizza em 8 pedaços\n";
    
    public virtual string Embalar() => "Embalar a pizza com embalagem oficial\n";
}