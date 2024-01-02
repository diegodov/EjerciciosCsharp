// capture user input in a string variable named readResult

int numericValue = 0;

bool validNumber = false;

do
{
    Console.Write("Ingrese un entero del 5 al 10: ");

    string readResult = Console.ReadLine();

    validNumber = int.TryParse(readResult, out numericValue);

    if (numericValue < 5 || numericValue > 10)
    {
        Console.WriteLine("El valor ingresado no esta en el rango entre 5 y 10.");
        validNumber = false;
    }
    else
    {
        Console.WriteLine($"Su numero ({numericValue}) ha sido aceptado.");
    }

} while (validNumber == false);