public class Aluno
{
    private string nome;
    private double nota;

    public string Nome
    {
        get { return nome; }
        set 
        { 
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio.");
            nome = value; 
        }
    }

    public double Nota
    {
        get { return nota; }
        set
        {
            if (value < 0 || value > 10)
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            nota = value;
        }
    }

    // Construtor
    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    // Método ToString
    public override string ToString()
    {
        string status = nota >= 6.0 ? "Aprovado" : "Reprovado";
        return $"Aluno: {Nome} | Nota: {Nota:F1} | Status: {status}";
    }
}