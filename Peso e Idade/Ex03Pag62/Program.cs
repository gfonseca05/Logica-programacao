int abaixo = 0;
int entre = 0;
double media;
for (int atleta = 0; atleta < 40; atleta++)
{
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite seu peso: ");
    double peso = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    if (peso < 75)
    {
        abaixo++;
    }
    if (idade < 24 && idade > 19)
    {
        entre++;
    }
    int total = 0;
    total = +idade;
    media = total / 40;
}

Console.WriteLine($"Atletas abaixo dos 75kg: {abaixo}");
Console.WriteLine($"Atletas entre 20 e 23 anos: {entre}");
Console.WriteLine($"Idade Média: {media}");
Console.ReadKey();