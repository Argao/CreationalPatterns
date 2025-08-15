using Builder.Domain;

namespace Builder;

public abstract class ComputadorBuilder
{
    public abstract void BuildSO();
    public abstract void BuildDispositivos();
    private Computador TipoComputador { get; }
}