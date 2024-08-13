// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Target = 9   Array = [11,15,2,7]*/

int[] numeros = { 11, 15, 2, 7 };

int target = 9, numero1 = 0, numero2 = 0;

//Esse menos 1 garante que sempre vamos estar no limite do array
for(int i = 0; i < numeros.Length - 1; i++)
{
    int calculo = numeros[i] + numeros[i + 1];
    if (calculo == target)
    {
        numero1 = numeros[i];
        numero2 = numeros[i + 1];
        Console.WriteLine($"O numeros onde a soma é igual 9 são : {numero1} e {numero2}");
    }
}