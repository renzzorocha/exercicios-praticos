string palavra = Console.ReadLine();

string palavraSemEspacos = palavra.Replace(" ", "");

int ultimo = 0;

for (int i = 1; i <= palavraSemEspacos.Length; i++)
{
    ultimo = i;
}

Console.WriteLine(ultimo);
