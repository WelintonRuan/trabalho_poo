

public class Retangulo
{
    
    private float basee;
    private float altura;

    
    public float Base
    {
        get { return basee; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O valor da base deve ser maior que zero");
            }
            else
            {
                basee = value;
            }
        }
    }

    public float Altura
    {
        get { return altura; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O valor da altura deve ser maior que zero");
            }
            else
            {
                altura = value;
            }
        }
    }

    
    public Retangulo(float basee, float altura)
    {
        
        Base = basee;
        Altura = altura;
    }

    
    public float CalcularArea()
    {
        return basee * altura;
    }

    
    public override string ToString()
    {
        return $"Retângulo [Base: {Base} | Altura: {Altura} | Área: {CalcularArea()}]";
    }
}