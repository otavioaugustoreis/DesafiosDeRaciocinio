// See https://aka.ms/new-console-template for more information



/*
 Dado um inteiro , retornar se for um xtruex
palíndromo
, e de outra forma.false

Exemplo 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
*/


bool resultado = InverterNumero(-121);

Console.WriteLine(resultado);
static bool InverterNumero(int x)
{

    bool solucao;
    bool isNegative = x < 0;

    if (isNegative)
    {
        return false;
    }
    // Converter o número para uma string
    string numeroString = Math.Abs(x).ToString(); ;

    // Inverter a string, esse ToChar converte strings em arrays
    char[] charArray = numeroString.ToCharArray();
    Array.Reverse(charArray);
    // aqui ele converte o array
    string numeroInvertidoString = new string(charArray);

    // Converter a string invertida de volta para um número
    long numeroInvertido = long.Parse(numeroInvertidoString);

    solucao = x == numeroInvertido ? true : false;

    return solucao;
}





