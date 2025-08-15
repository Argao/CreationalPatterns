// See https://aka.ms/new-console-template for more information

using Builder;

var fabricante = new Fabricante();

var notebookBuilder = new NotebookBuilder();
var desktopBuilder = new DesktopBuilder();

fabricante.Build(notebookBuilder);
fabricante.Build(desktopBuilder);

