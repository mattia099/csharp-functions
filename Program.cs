Console.Write($"\nInserisci lunghezza dell'array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

Console.WriteLine($"\nInserisci {arrayLength} numeri:");
for (int i = 0; i < arrayLength; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"\nArray principale: ");
StampaArray(array);

Console.Write($"\nArray elevato al quadrato: ");
StampaArray(ElevaArrayAlQuadrato(array));

Console.Write($"\nSomma elementi all'interno dell'array principale: ");
Console.WriteLine(sommaElementiArray(array));

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write($" {array[i]} "); 
    }
    Console.Write("]");
};

int Quadrato(int numero)
{
    return numero * numero;
};

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i]=Quadrato(array[i]);
    }
    return newArray;
};

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}
