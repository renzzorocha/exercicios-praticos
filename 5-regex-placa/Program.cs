class Program
{
    static void Main()
    {
        bool validadorDePlaca = validarPlaca("rnz777a");

        Console.WriteLine(validadorDePlaca);
    }

    static bool validarPlaca(string placa)
    {
        if(placa == null || placa.Length != 7) return false;

        for(int i = 0; i < 3;  i++) 
            if(!char.IsLetter(placa[i])) return false;

        for (int i = 3; i < 7; i++)
            if (!char.IsDigit(placa[i])) return false;

        return true;
    }
}