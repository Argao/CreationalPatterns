using System.Text;

namespace FluentBuilder2;

public class EmailReport
{
    public string Enderecamento { get; set; }
    public string MontagemEmail { get; set; }

    public override string ToString() =>
        new StringBuilder()
            .AppendLine(Enderecamento)
            .AppendLine(MontagemEmail)
            .ToString();
}