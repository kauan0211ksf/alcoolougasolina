Console.Clear();

Console.WriteLine("-- Alcool Ou Gasolina --\n");

    Console.Write("Digite o valor do etanol: ");
double valorEtanol = double.Parse(Console.ReadLine()!);

    Console.Write("Digite o valor da gasolina: ");
double valorGasolina = double.Parse(Console.ReadLine()!);

double razaoPrecos = CalcularRazaoPrecos(valorEtanol, valorGasolina);
double razaoPrecosPorcentagem = razaoPrecos * 100;
    Console.WriteLine($"Razão entre os preços: {razaoPrecosPorcentagem:N1}%");

bool abastecerComGasolina = VerificarRecomendacao(razaoPrecos);
    Console.WriteLine($"Recomendação: Abastecer com {((abastecerComGasolina) ? "Gasolina" : "Etanol")}");

static double CalcularRazaoPrecos(double valorEtanol, double valorGasolina) {
return valorEtanol / valorGasolina;
}

static bool VerificarRecomendacao(double razaoPrecos) {
double percentualIdeal = 0.73;
return razaoPrecos > percentualIdeal;
}

