public static class Unit_tests 
{
    public static void Task1()
    {
        // конструктор
        ComplexNumber c1 = new ComplexNumber(3, 4);
        ComplexNumber c2 = new ComplexNumber(1, 2);
        Console.WriteLine($"c1 = {c1}");
        Console.WriteLine($"c2 = {c2}");

        // сложениe
        ComplexNumber sum = c1 + c2;
        Console.WriteLine($"\n{c1} + {c2} = {sum}");

        // вычитаниe
        ComplexNumber diff = c1 - c2;
        Console.WriteLine($"\n{c1} - {c2} = {diff}");

        // умножениe
        ComplexNumber mult = c1 * c2;
        Console.WriteLine($"\n{c1} * {c2} = {mult}");

        // делениe
        ComplexNumber div = c1 / c2;
        Console.WriteLine($"\n{c1} / {c2} = {div}");

        // Унарный +
        double modulus = +c1;
        Console.WriteLine($"\n|{c1}| = {modulus}");

        // Унарный -
        ComplexNumber conjugate = -c1;
        Console.WriteLine($"\nСопряженное для {c1} = {conjugate}");

        // сравнениe
        ComplexNumber c3 = new ComplexNumber(3, 4);
        Console.WriteLine($"\n{c1} == {c3}? {c1 == c3}");
        Console.WriteLine($"{c1} != {c2}? {c1 != c2}");

        // ToString
        Console.WriteLine($"new ComplexNumber(0, 0) = {new ComplexNumber(0, 0)}");
        Console.WriteLine($"new ComplexNumber(0, 5) = {new ComplexNumber(0, 5)}");
        Console.WriteLine($"new ComplexNumber(3, 0) = {new ComplexNumber(3, 0)}");
        Console.WriteLine($"new ComplexNumber(3, 5) = {new ComplexNumber(3, 5)}");
        Console.WriteLine($"new ComplexNumber(3, -5) = {new ComplexNumber(3, -5)}");
    }
}
