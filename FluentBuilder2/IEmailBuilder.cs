namespace FluentBuilder2;

public interface IEmailBuilder
{
    void MontaEnderecamento();
    void MontaCorpoEmail();
    EmailReport GetEmail();
}