// buscador de matriculas

string[] matriculas = { "ABC123", "DEF456", "GHI789", "JKL012", "MNO345", "PQR678", "STU901", "VWX234", "YZA567", "BCD890", "BGH234" };

Console.Write("Introduce la matricula a buscar: ");
string matricula = Console.ReadLine();

string[] resultados = new string[matriculas.Length];

int count = 0;

for (int i = 0; i < matriculas.Length; i++) {
    if (matriculas[i].Contains(matricula)) {
        resultados[count] = matriculas[i];
        count++;
    }
}

foreach (string resultado in resultados) {
    if (resultado != null) {
        Console.WriteLine(resultado);
    }
}

Console.WriteLine($"Se han encontrado {count} resultado(s).");