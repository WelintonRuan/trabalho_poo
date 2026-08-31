

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("test retangulo");
        
        Retangulo r1 = new Retangulo(5.0f, 3.0f);
        Retangulo r2 = new Retangulo(10.0f, 4.5f);

        Console.WriteLine(r1);
        Console.WriteLine(r2);


       
        float areaR1 = r1.CalcularArea();
        Console.WriteLine($"Base do R1 (Property Get): {r1.Base}");
        Console.WriteLine($"Altura do R1 (Property Get): {r1.Altura}");
        Console.WriteLine($"Área calculada do Retângulo 1: {areaR1} m²");

        r1.Base = 8.0f;
        Console.WriteLine($"Nova Área do Retângulo 1: {r1.CalcularArea()} m²");
        Console.WriteLine($"Objeto R1 atualizado: {r1}\n\n");

        Console.WriteLine("test bhaskara");
        Bhaskara eq1 = new Bhaskara(1, -3, 2);  
        Bhaskara eq2 = new Bhaskara(1, 2, 5);   

        Console.WriteLine(eq1);
        Console.WriteLine(eq2);

        Console.WriteLine($"Valor de A: {eq1.A} | B: {eq1.B} | C: {eq1.C}");
        Console.WriteLine($"Delta calculado da Equação 1: {eq1.CalcularDelta()}");
        Console.WriteLine($"Raiz X1 (x'): {eq1.CalcularX1()}");
        Console.WriteLine($"Raiz X2 (x''): {eq1.CalcularX2()}");

        eq1.B = -5;
        eq1.C = 6;
        Console.WriteLine($"{eq1.CalcularDelta()}");
        Console.WriteLine($"{eq1.CalcularX1()} | X2 = {eq1.CalcularX2()}");
        Console.WriteLine($"{eq1}\n\n");

        Console.WriteLine("test aluno");
        Aluno a1 = new Aluno("Carlos", 5.5);
        Aluno a2 = new Aluno("Mariana", 9.0);

        Console.WriteLine(a1);
        Console.WriteLine(a2);

        Console.WriteLine($"Nome do aluno a1: {a1.Nome}");
        Console.WriteLine($"{a1.Nota}");

        a1.Nota = 7.5;
        Console.WriteLine($"Nova nota: {a1.Nota}");
        Console.WriteLine($"{a1}");
    }
}