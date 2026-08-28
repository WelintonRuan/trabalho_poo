using System.Formats.Asn1;

public class Retangulo
{
    private float basee;

    private float altura;

    public float Base
    {
        get {return basee;}

        set
        {
            if (value <=0)
            {
                Console.WriteLine("Valor da base não pode ser negativo e nem 0");

            }
            else
            {
                basee = value;
            }
        
        }
    }

    public float Altura
    {
        get {return altura;}

        set
        {
            if (value <=0)
            {
                Console.WriteLine("Valor da altura não pode ser negativo e nem 0");
            }
            else
            {
                altura = value;
            }   
        }
    }

    public float CalcularArea()
    {
        float Area = basee * altura;
        return Area;
    }







































}