using Builder.Domain;

namespace Builder;


public class DesktopBuilder : ComputadorBuilder
{
    public override void BuildSO()
    {

        Console.WriteLine("Build Sistema Operacional no Desktop ...");
    }

    public override void BuildDispositivos()
    {
        Console.WriteLine("Build Dispositivos no Desktop ...");   
    }

    public Computador TipoComputador { get; } = new(Domain.TipoComputador.Desktop);
}