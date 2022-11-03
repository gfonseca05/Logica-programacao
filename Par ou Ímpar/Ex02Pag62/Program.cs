
int par = 0;
int impar = 0;
for (int cont = 0; cont < 20; cont++)
{
    Console.WriteLine("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    
    if (numero % 2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }
    
}
Console.WriteLine($"Foram escritos {par} números pares e {impar} números ímpares");
Console.ReadKey();