class ComplexNumber
{
    public double Real { get; }
    public double Imagine { get; }

    public ComplexNumber(double real, double imagine)
    {
        Real = real;
        Imagine = imagine;
    }

    public static ComplexNumber operator +(ComplexNumber x1, ComplexNumber x2)
    {
        return new ComplexNumber(x1.Real + x2.Real, x1.Imagine + x2.Imagine);
    }

    public static ComplexNumber operator -(ComplexNumber x1, ComplexNumber x2)
    {
        return new ComplexNumber(x1.Real - x2.Real, x1.Imagine - x2.Imagine);
    }

    public static ComplexNumber operator *(ComplexNumber x1, ComplexNumber x2)
    {
        double real = x1.Real * x2.Real - x1.Imagine * x2.Imagine;
        double imagine = x1.Real * x2.Imagine + x1.Imagine * x2.Real;
        return new ComplexNumber(real, imagine);
    }

    public static ComplexNumber operator /(ComplexNumber x1, ComplexNumber x2)
    {
        double denominator = x2.Real * x2.Real + x2.Imagine * x2.Imagine;
        if (denominator == 0)
            throw new DivideByZeroException("Деление на ноль невозможно");

        double real = (x1.Real * x2.Real + x1.Imagine * x2.Imagine) / denominator;
        double imagine = (x1.Imagine * x2.Real - x1.Real * x2.Imagine) / denominator;
        return new ComplexNumber(real, imagine);
    }

    public static bool operator ==(ComplexNumber x1, ComplexNumber x2)
    {
        if (ReferenceEquals(x1, null) || ReferenceEquals(x2, null))
            return ReferenceEquals(x1, x2);
        return x1.Real == x2.Real && x1.Imagine == x2.Imagine;
    }

    public static bool operator !=(ComplexNumber x1, ComplexNumber x2)
    {
        return !(x1 == x2);
    }

    public static double operator +(ComplexNumber x)
    {
        return Math.Sqrt(x.Real * x.Real + x.Imagine * x.Imagine);
    }

    public static ComplexNumber operator -(ComplexNumber x)
    {
        return new ComplexNumber(x.Real, -x.Imagine);
    }

    public override string ToString()
    {
        if (Real == 0 && Imagine == 0)
            return "0";
        else if (Real == 0)
            return $"{Imagine}i";
        else if (Imagine == 0)
            return $"{Real}";
        else if (Imagine > 0)
            return $"{Real} + {Imagine}i";
        else
            return $"{Real} - {-Imagine}i";
    }


    public override bool Equals(object? obj) // ? для разрешиния null
    {
        if (ReferenceEquals(this, obj))
            return true;
        if (ReferenceEquals(obj, null))
            return false;
        if (GetType() != obj.GetType())
            return false;

        ComplexNumber other = (ComplexNumber)obj;
        return Real == other.Real && Imagine == other.Imagine;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Real, Imagine);
    }
}
