using System;

namespace FluentBuilder2;

public class ConcreteEmail : IEmailBuilder
{
    private EmailReport _emailReport;
    private Email _email;
    public ConcreteEmail(Email email)
    {
        _email = email;
        _emailReport = new EmailReport();
    }
    public void MontaCorpoEmail()
    {
        _emailReport.MontagemEmail = string.Join(Environment.NewLine, $"{_email.Subject} \n {_email.Body}");
    }

    public void MontaEnderecamento()
    {
        _emailReport.Enderecamento = string.Join(Environment.NewLine, $"{_email.To}, \n {_email.From}");
    }
    public EmailReport GetEmail()
    {
        var email = _emailReport;
        return email;
    }
}