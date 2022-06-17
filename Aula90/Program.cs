
Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("CAIXA DE SUPERMERCADO!");
Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine(" ");
Console.Write("Quantos produtos você quer somar?: ");

int N = int.Parse(Console.ReadLine());
int soma = 0;

for (int i = 1; i <= N; i++) {
    Console.Write("Valor do produto: #{0}: ", i);
    int valor = int.Parse(Console.ReadLine());
    soma += valor;
}

Console.WriteLine(" ");
Console.WriteLine($"Valor total da compra: {soma} reais");


