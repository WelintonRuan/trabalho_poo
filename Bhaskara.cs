
public class Bhaskara
{
    
    private double a;
    private double b;
    private double c;

    
    public double A
    {
        get { return a; }
        set
        {
            
            if (value == 0)
            {
                throw new ArgumentException("O coeficiente a não pode ser zero");
            }
            a = value;
        }
    }

    public double B
    {
        get { return b; }
        set { b = value; }
    }

    public double C
    {
        get { return c; }
        set { c = value; }
    }

    
    public Bhaskara(double a, double b, double c)
    {
        A = a; 
        B = b;
        C = c;
    }

   
    public double CalcularDelta()
    {
        return (b * b) - (4 * a * c);
    }

    public double? CalcularX1()
    {
        double delta = CalcularDelta();
        if (delta < 0) return null; 
        return (-b + Math.Sqrt(delta)) / (2 * a);
    }

    public double? CalcularX2()
    {
        double delta = CalcularDelta();
        if (delta < 0) return null;
        return (-b - Math.Sqrt(delta)) / (2 * a);
    }

    
    public override string ToString()
    {
        double delta = CalcularDelta();
        
        if (delta < 0)
        {
            return $"Equação: {a}x² + ({b})x + ({c}) | Delta: {delta} | sem raízes reais";
        }

        return $"Equação: {a}x² + ({b})x + ({c}) | Delta: {delta} | X' = {CalcularX1():F2} | X'' = {CalcularX2():F2}";
    }
}