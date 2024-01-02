/* 
 * * Autor: @diegodov
 * * 
 * * Descripción: Uso de do-while para validar una cadena de texto 
 * *
 * */

bool valido = false;

do
{ 
    Console.Write("Ingrese el rol: ");

    string? entrada = Console.ReadLine();

    string? orden = entrada.Trim().ToLower();

    if (orden == "administrador" || orden == "manager" || orden == "user" )
    {
        Console.WriteLine($"El rol ({entrada}) es valido");
        valido = true;
    } else
    {
        Console.WriteLine("El rol ingresado no es valido");
    }

} while (valido == false);






