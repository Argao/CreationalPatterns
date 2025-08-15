using System;
using FluentBuilder;

var emailBuilder = new EmailBuilder();

var email = emailBuilder
    .To("microsoft@email.com")
    .From("macoratti@yahoo.com")
    .Subject("Micrsofot Build")
    .Body("Microsoft Build 2021\n\t25 a 27 de Maio 2021" +
          "\n\tNovidades Windows,Azure,Office e mais")
    .CriaEmail();

Console.WriteLine(email.ToString());
Console.ReadLine();