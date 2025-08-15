using Builder.Domain;

namespace Builder;

public class NotebookBuilder : ComputadorBuilder
{
    public Computador TipoComputador { get; } = new(Domain.TipoComputador.Notebook);
    
    public override void BuildSO()
    {
        Console.WriteLine("Build Sistema Operacional no Notebook ...");
    }

    public override void BuildDispositivos()
    {
        Console.WriteLine("Build Dispositivos no notebook");
    }
}