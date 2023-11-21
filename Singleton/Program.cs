// See https://aka.ms/new-console-template for more information
Console.WriteLine(Singleton.Singleton.Instance.mensaje);
Singleton.Singleton.Instance.mensaje = "Hola mundo desde el singleton";
Console.WriteLine(Singleton.Singleton.Instance.mensaje);
