class ComplexNumber
{
    private int real;

    private int imagine;

    public ComplexNumber(int realx, int imaginex)
    {
        real = realx;
        imagine = imaginex;
    }

    public static ComplexNumber operator +(ComplexNumber x1, ComplexNumber x2)
    {
        ComplexNumber result = new ComplexNumber(0, 0);
        result.real = x1.real + x2.real;
        result.imagine = x1.imagine + x2.imagine;
        return result;
    }

    public static ComplexNumber operator -(ComplexNumber x1, ComplexNumber x2)
    {
        ComplexNumber result = new ComplexNumber(0, 0);
        result.real = x1.real - x2.real;
        result.imagine = x1.imagine - x2.imagine;
        return result;
    }

    public static ComplexNumber operator *(ComplexNumber x1, ComplexNumber x2)
    {
        ComplexNumber result = new ComplexNumber(0, 0);
        result.real = x1.real * x2.real;
        result.imagine = x1.imagine * x2.imagine;
        return result;
    }

    public static ComplexNumber operator /(ComplexNumber x1, ComplexNumber x2)
    {
        ComplexNumber result = new ComplexNumber(0, 0);
        result.real = x1.real / x2.real;
        result.imagine = x1.imagine / x2.imagine;
        return result;
    }

    public static bool operator ==(ComplexNumber x1, ComplexNumber x2)
    {
        if ((x1.real == x2.real) && (x1.imagine == x2.imagine))
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(ComplexNumber x1, ComplexNumber x2)
    {
        if ((x1.real != x2.real) || (x1.imagine != x2.imagine))
        {
            return true;
        }
        return false;
    }

    public string ToString()
    {
        return string.Format("{0} + {1}i", real, imagine);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(obj, null))
        {
            return false;
        }

        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}
