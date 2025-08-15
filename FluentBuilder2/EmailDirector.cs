namespace FluentBuilder2;

public class EmailDirector
{
    private readonly IEmailBuilder _emailBuilder;
    public EmailDirector(IEmailBuilder emailBuilder)
    {
        _emailBuilder = emailBuilder;
    }

    public void ConstroiEmail()
    {
        _emailBuilder.MontaEnderecamento();
        _emailBuilder.MontaCorpoEmail();
    }
}