namespace _3_calculadora
{
    public static class Calculadora
    {
        public static double Somar(double a, double b) => a + b;

        public static double Subtrair(double a, double b) => a - b;

        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();

        public static double Media(double a, double b) => (a + b) / 2;
    }
}
